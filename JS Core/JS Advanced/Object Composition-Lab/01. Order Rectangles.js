function orderRec(array) {
    for (let i = 0; i < array.length; i++) {
        array[i] = {
            width: array[i][0],
            height: array[i][1],
            area: function () {
                return this.width*this.height;
            },
            compareTo: function (other) {
                let result = other.area() - this.area();
                return result || (other.width - this.width);
            }
        }
    }

    array.sort((a,b) => a.compareTo(b));
    
    return array;
}
