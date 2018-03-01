let expect = require('chai').expect;

function sum(arr) {
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}

describe("SumArrayTests", function() {
    it("should return 5 when sum[1,2,2]", function() {
        expect(sum([1,2,2])).to.be.equal(5);
    });
    it("should return 0 when the array is empty", function() {
        expect(sum([])).to.be.equal(0);
    });
    it("should work with negative numbers", function() {
        expect(sum([-1,-2,-3])).to.be.equal(-6);
    });
    it("should return the same number if the array contains one element", function() {
        expect(sum([6])).to.be.equal(6);
    });
    it("should work with decimals", function() {
        expect(sum([-1.5,2,3.4])).to.be.equal(3.9);
    });
    it("should return NaN if the array contains element which is not a number", function() {
        expect(sum([-1.5,2,'test'])).to.be.NaN;
    });
});
