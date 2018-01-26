function diagonalAttack(input) {
    let matrix = [];
    for (let i = 0; i < input.length; i++) {
        matrix[i] = input[i].split(' ').map(e => Number(e));
    }

    let firstDiagonal = 0;
    let secondDiagonal = 0;
    let rowsLength = matrix.length;
    let colsLength = matrix[0].length;

    for (let row = 0; row < rowsLength; row++) {
        firstDiagonal += matrix[row][row];
        secondDiagonal += matrix[row][colsLength - 1 - row];
    }

   if(firstDiagonal == secondDiagonal){
       for (let row = 0; row < rowsLength; row++) {
           for (let col = 0; col < colsLength; col++) {
               if((col != row) && (col != colsLength-1-row)){
                   matrix[row][col] = firstDiagonal;
               }
           }
       }

       console.log(matrix.map(row => row.join(' ')).join('\n'));
   }
   else {
       console.log(matrix.map(row => row.join(' ')).join('\n'));
   }
}
