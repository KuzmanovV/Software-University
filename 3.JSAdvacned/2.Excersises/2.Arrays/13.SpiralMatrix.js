function solve(x, y) {
    matrix = [];
    let start = 0;
    for (let i = 0; i < x-1; i++) {
        for (let j = 0; j < y-1; j++) {
            matrix[j][i] = start++;           
        }
    }
}

solve(5, 5)