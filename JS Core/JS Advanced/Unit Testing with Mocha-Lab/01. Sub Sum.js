function subSum(array,startIndex,endIndex) {

    if(!Array.isArray(array)){
        return NaN;
    }

    array = array.map(e=>Number(e));

    if(startIndex < 0){
        startIndex = 0;
    }

    if(endIndex >= array.length){
        endIndex = array.length-1;
    }

    let sum = 0;
    for (let i = startIndex; i <= endIndex; i++) {
        sum += array[i];
    }

    return sum;
}
