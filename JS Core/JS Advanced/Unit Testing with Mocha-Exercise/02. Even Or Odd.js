function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}

let expect = require('chai').expect;

describe('IsOddOrEvenTests',function () {
    it('should return undefined', function () {
        expect(isOddOrEven(5)).to.be.undefined;
        expect(isOddOrEven()).to.be.undefined;
    });

    it('should return even', function () {
        expect(isOddOrEven('even')).to.equal('even');
        expect(isOddOrEven('')).to.equal('even');
    });

    it('should return odd', function () {
        expect(isOddOrEven('think')).to.equal('odd');
    });
});
