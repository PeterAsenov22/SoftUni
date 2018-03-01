let expect = require('chai').expect;

function isSymmetric(arr) {
    if (!Array.isArray(arr))
        return false; // Non-arrays are non-symmetric
    let reversed = arr.slice(0).reverse(); // Clone and reverse
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
}

describe("IsSymmetricTests",function () {
    it("should return false if the argument is not array",function () {
        expect(isSymmetric(5)).to.be.false;
    });
    it('should return true if array contains one element', function () {
        expect(isSymmetric([5])).to.be.true;
    });
    it('should work with strings', function () {
        expect(isSymmetric(['5','argh','try','argh','5'])).to.be.true;
    });
    it('should work with negative numbers', function () {
        expect(isSymmetric([-1,-2,-1])).to.be.true;
    });
    it('should return true when symmetric', function () {
        expect(isSymmetric([5,3,2,1,2,3,5])).to.be.true;
    });
    it('should return false when not-symmetric', function () {
        expect(isSymmetric([5,3,2,1,2,4,5])).to.be.false;
    });
    it('should return true when symmetric with even length', function () {
        expect(isSymmetric([5,3,2,1,2,3,5])).to.be.true;
    });
    it('should return false when not-symmetric with even length', function () {
        expect(isSymmetric([5,3,2,1])).to.be.false;
    });
    it('should return true when the array is empty', function () {
        expect(isSymmetric([])).to.be.true;
    });
    it('should return false [true,1]', function () {
        expect(isSymmetric([true,'1'])).to.be.false;
    });
});
