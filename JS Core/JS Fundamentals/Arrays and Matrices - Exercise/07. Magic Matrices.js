function magicMatrices(matrix) {
    let rowsCount = matrix.length;
    let colsCount = matrix[0].length;

    let sum = 0;
    for (let col = 0; col < colsCount ; col++) {
        sum += matrix[0][col];
    }

    for (let row = 1; row < rowsCount; row++) {
        let currentSum = 0;
        for (let col = 0; col < colsCount ; col++) {
            currentSum += matrix[row][col];
        }

        if(currentSum != sum){
            return false;
        }
    }

    for (let col = 0; col < colsCount; col++) {
        let currentSum = 0;
        for (let row = 0; row < rowsCount; row++) {
            currentSum += matrix[col][row];
        }

        if(currentSum != sum){
            return false;
        }
    }

    return true;
}
