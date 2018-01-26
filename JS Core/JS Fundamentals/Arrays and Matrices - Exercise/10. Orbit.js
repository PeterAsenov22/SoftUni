function orbit(arr) {
    let colsLength = arr[0];
    let rowsLength = arr[1];
    let xRow = arr[2];
    let xCol = arr[3];

    let matrix = [];
    for (let i = 0; i < rowsLength; i++) {
        matrix.push([]);
        for (let j = 0; j < colsLength; j++) {
            matrix[i].push(0);
        }
    }

    matrix[xRow][xCol] = 1;

    for (let i = 0; i < rowsLength; i++) {
        for (let j = 0; j < colsLength; j++) {
            let currEl = matrix[i][j];
            if(currEl == 0){
                let rowDiff = Math.abs(xRow-i);
                let colDiff = Math.abs(xCol-j);

                if(colDiff==0){
                    matrix[i][j] = 1 + rowDiff;
                }
                else if(rowDiff==0 || colDiff == rowDiff){
                    matrix[i][j] = 1 + colDiff;
                }
                else {
                    if(rowDiff>colDiff){
                        matrix[i][j] = 1 + rowDiff;
                    }
                    else {
                        matrix[i][j] = 1 + colDiff;
                    }
                }
            }
        }
    }

    console.log(matrix.map(row => row.join(' ')).join('\n'));
}
