class Console {
    static get placeholder() {
        return /{\d+}/g;
    }

    static writeLine() {
        let message = arguments[0];
        if (arguments.length === 1) {
            if (typeof (message) === 'object') {
                message = JSON.stringify(message);
                return message;
            }
            else if (typeof(message) === 'string') {
                return message;
            }
        }
        else {
            if (typeof (message) !== 'string') {
                throw new TypeError("No string format given!");
            }
            else {
                let tokens = message.match(this.placeholder).sort(function (a, b) {
                    a = Number(a.substring(1, a.length - 1));
                    b = Number(b.substring(1, b.length - 1));
                    return a - b;
                });
                if (tokens.length !== (arguments.length - 1)) {
                    throw new RangeError("Incorrect amount of parameters given!");
                }
                else {
                    for (let i = 0; i < tokens.length; i++) {
                        let number = Number(tokens[i].substring(1, tokens[i].length - 1));
                        if (number !== i) {
                            throw new RangeError("Incorrect placeholders given!");
                        }
                        else {
                            message = message.replace(tokens[i], arguments[i + 1])
                        }
                    }
                    return message;
                }
            }
        }
    }
}

let expect = require('chai').expect;

describe('SpecialConsoleTests',function () {
    it('should return the same string', function () {
        let result = Console.writeLine('pesho');
        expect(result).to.equal('pesho');
    });
    it('should return jsonObject when object is passed', function () {
        let obj = {name: 'petar', age: 5};
        let result = Console.writeLine(obj);
        expect(result).to.equal(JSON.stringify(obj));
    });
    it('should return jsonObject when array is passed', function () {
        let array = ['pesho','ivan'];
        let result = Console.writeLine(array);
        expect(result).to.equal(JSON.stringify(array));
    });
    it('should return undefined', function () {
        expect(Console.writeLine(5)).to.be.undefined;
        expect(Console.writeLine(5.5)).to.be.undefined;
        expect(Console.writeLine(-5)).to.be.undefined;
    });
    it('should throw error when invoked without parameters', function () {
        expect(function(){Console.writeLine()}).to.throw('No string format given!');
    });
    it('should throw error when the first argument is not string', function () {
        expect(function(){Console.writeLine(5,5)}).to.throw('No string format given!');
    });
    it('should throw error when placeholders count are not equal to parameters', function () {
        expect(function(){Console.writeLine('The sum of {0} and {1} is {2}', 3, 4)}).to.throw('Incorrect amount of parameters given!');
        expect(function(){Console.writeLine('The sum of {-1} and {0} is 5', 3, 4)}).to.throw('Incorrect amount of parameters given!');
    });
    it('should throw error when invalid placeholders are given', function () {
        expect(function(){Console.writeLine('The sum of {0} and {1} is {4}', 3, 4, 5)}).to.throw('Incorrect placeholders given!');
        expect(function(){Console.writeLine('The sum of {6} and {0} is {1}', 3, 4, 5)}).to.throw('Incorrect placeholders given!');
    });
    it('should return correct message', function () {
        expect(Console.writeLine('The sum of {0} and {1} is {2}', 3, 4, 7)).to.equal('The sum of 3 and 4 is 7');
        expect(Console.writeLine('The sum {-1} of {0} and {1} is {2}', 3, 4, 7)).to.equal('The sum {-1} of 3 and 4 is 7');
    });
    it('should return correct placeholder regex', function () {
        expect(Console.placeholder.toString()).to.equal('/{\\d+}/g');
    });
});
