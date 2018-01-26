function diagonalSums(matrix) {
    let firstDiagonal = 0;
    let secondDiagonal = 0;
    let rowsLength = matrix.length;
    let colsLength = matrix[0].length;

    for (let row = 0; row < rowsLength; row++) {
        firstDiagonal += matrix[row][row];
        secondDiagonal += matrix[row][colsLength - 1 - row];
    }

    console.log(firstDiagonal + ' ' + secondDiagonal);
}
