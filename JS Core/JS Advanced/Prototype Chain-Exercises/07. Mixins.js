function createMixins() {
    function computerQualityMixin(classToExtend){
        classToExtend.prototype.getQuality = function () {
            return (this.processorSpeed + this.ram + this.hardDiskSpace)/3;
        };
        classToExtend.prototype.isFast = function () {
            if(this.processorSpeed > (this.ram/4)){
                return true;
            }
            else{
                return false;
            }
        };
        classToExtend.prototype.isRoomy = function () {
            if(this.hardDiskSpace > (Math.floor(this.ram*this.processorSpeed))){
                return true;
            }
            else{
                return false;
            }
        };
    }

    function styleMixin(classToExtend){
        classToExtend.prototype.isFullSet = function () {
            console.log(this.monitor.manufacturer);
            console.log(this.keyboard.manufacturer);
            console.log(this.manufacturer);

            if(this.monitor.manufacturer == this.manufacturer && this.keyboard.manufacturer == this.manufacturer){
                return true;
            }
            else{
                return false;
            }
        };
        classToExtend.prototype.isClassy = function () {
            if(this.battery.expectedLife >=3 && (this.color == 'Silver' || this.color == 'Black')
                && this.weight < 3){
                return true;
            }
            else{
                return false;
            }
        };
    }

    return {
        computerQualityMixin,
        styleMixin
    }
}
