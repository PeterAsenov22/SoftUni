function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255))
        return undefined; // Red value is invalid
    if (!Number.isInteger(green) || (green < 0) || (green > 255))
        return undefined; // Green value is invalid
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
        return undefined; // Blue value is invalid
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}

let expect = require('chai').expect;

describe('Rgb Tests',function () {
    it('should return undefined {red,150,150}', function () {
        expect(rgbToHexColor('red',150,150)).to.be.undefined;
    });
    it('should return undefined {-1,150,150}', function () {
        expect(rgbToHexColor(-1,150,150)).to.be.undefined;
    });
    it('should return undefined {300,255,150}', function () {
        expect(rgbToHexColor(300,255,150)).to.be.undefined;
    });
    it('should return undefined {150,green,150}', function () {
        expect(rgbToHexColor(150,'green',150)).to.be.undefined;
    });
    it('should return undefined {150,-2,150}', function () {
        expect(rgbToHexColor(150,-2,150)).to.be.undefined;
    });
    it('should return undefined {150,300,150}', function () {
        expect(rgbToHexColor(150,300,150)).to.be.undefined;
    });
    it('should return undefined {150,150,blue}', function () {
        expect(rgbToHexColor(150,150,'blue')).to.be.undefined;
    });
    it('should return undefined {150,150,-2}', function () {
        expect(rgbToHexColor(150,150,-2)).to.be.undefined;
    });
    it('should return undefined {150,150,300}', function () {
        expect(rgbToHexColor(150,150,300)).to.be.undefined;
    });
    it('should return #03FA50 {3,250,80}', function () {
        expect(rgbToHexColor(3,250,80)).to.equal('#03FA50');
    });
    it('should return #64FA50 {100,250,80}', function () {
        expect(rgbToHexColor(100,250,80)).to.equal('#64FA50');
    });
    it('should return #040404 {4,4,4}', function () {
        expect(rgbToHexColor(4,4,4)).to.equal('#040404');
    });
    it('should return #000000 {0,0,0}', function () {
        expect(rgbToHexColor(0,0,0)).to.equal('#000000');
    });
    it('should return undefined', function () {
        expect(rgbToHexColor()).to.be.undefined;
    });
    it('should return #FFFFFF {255,255,255}', function () {
        expect(rgbToHexColor(255,255,255)).to.equal('#FFFFFF');
    });
});
