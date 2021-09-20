function solve(inputArr) {
    const matrix = [];
    for (const iterator of inputArr) {
        numberedIterator = iterator.split(' ').map(Number);
        matrix.push(numberedIterator);
    }

    let firstDiag = 0;
    for (let i = 0; i < matrix.length; i++) {
            firstDiag+=matrix[i][i];            
        }
    let secondDiag = 0;
    let fixed = [];
    for (let i = 0; i < matrix.length; i++) {
        secondDiag+=matrix[matrix.length-1-i][i];
    }
    if (firstDiag==secondDiag) {
        for (let i = 0; i < matrix.length; i++) {
            for (let j = 0; j < matrix.length; j++) {
                if (i!=j && (i+j)!=(matrix.length-1)) {
                    matrix[i][j]=firstDiag;
                }
            }            
        }
    }

    for (const iterator of matrix) {
        console.log(iterator.join(' '));
    }
}

solve(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1']
)

solve(['1 1 1',
'1 1 1',
'1 1 0']
)