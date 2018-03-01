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
