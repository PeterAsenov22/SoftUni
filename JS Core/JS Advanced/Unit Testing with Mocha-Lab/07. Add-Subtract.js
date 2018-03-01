function createCalculator() {
    let value = 0;
    return {
        add: function(num) { value += Number(num); },
        subtract: function(num) { value -= Number(num); },
        get: function() { return value; }
    }
}
let expect = require('chai').expect;

describe('CreateCalculatorTests',function () {
    let calc;
    beforeEach(()=>{
        calc = createCalculator();
    });
    it('should be object', function () {
        expect(typeof calc).to.equal('object');
    });
    it('should return 0', function () {
        expect(calc.get()).to.equal(0);
    });
    it('should return 5', function () {
        calc.add(2);
        calc.add(3);
        expect(calc.get()).to.equal(5);
    });
    it('should return 5', function () {
        calc.add('5');
        expect(calc.get()).to.equal(5);
    });
    it('should return 10', function () {
        calc.add('5');
        calc.add('15');
        calc.subtract('10');
        expect(calc.get()).to.equal(10);
    });
    it('should return -5', function () {
        calc.subtract(5);
        expect(calc.get()).to.equal(-5);
    });
    it('should return -2', function () {
        calc.add('-2');
        expect(calc.get()).to.equal(-2);
    });
    it('should return 2', function () {
        calc.subtract('-2');
        expect(calc.get()).to.equal(2);
    });
    it('should return NaN', function () {
        calc.add('pesho');
        expect(calc.get()).to.be.NaN;
    });
});
