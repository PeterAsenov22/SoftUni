function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}

let expect = require('chai').expect;

describe('CharLookupTests',function () {
    it('should return undefined', function () {
        expect(lookupChar(5,5)).to.be.undefined;
        expect(lookupChar(5,'wkfqe')).to.be.undefined;
        expect(lookupChar('','')).to.be.undefined;
        expect(lookupChar()).to.be.undefined;
        expect(lookupChar(5)).to.be.undefined;
        expect(lookupChar('test',3.12)).to.be.undefined;
    });

    it('should return Incorrect index', function () {
        expect(lookupChar('test',4)).to.equal('Incorrect index');
        expect(lookupChar('test',5)).to.equal('Incorrect index');
        expect(lookupChar('test',-1)).to.equal('Incorrect index');
        expect(lookupChar('',0)).to.equal('Incorrect index');
    });

    it('should return "a"', function () {
        expect(lookupChar('whatever',2)).to.equal('a');
    });
});
