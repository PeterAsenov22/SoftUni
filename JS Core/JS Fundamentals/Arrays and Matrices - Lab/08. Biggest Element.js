function biggestElement(matrix) {
    let biggestNum = Number.NEGATIVE_INFINITY;

    matrix.forEach(row =>
        row.forEach(e => {if(e>biggestNum){
        biggestNum = e
    }}));
    
    return biggestNum;
}
