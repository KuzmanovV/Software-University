function solve(movesArr) {
    let board = [
        [false, false, false],
        [false, false, false],
        [false, false, false]
    ];

    let isPlayerX = true;
    for (const iterator of movesArr) {
        let [row, col] = iterator.split(' ').map(x=>Number(x));

        if (board[row][col]!==false) {
            console.log('This place is already taken. Please choose another!');
        }

        board[row][col] = isPlayerX ? 'X' : 'O'
        isPlayerX = !isPlayerX;
    }

    function GameEnded(board) {
        for (let row = 0; row < 3; row++) {
            let allEqualsX = board[row].every(x=>x==='X')            
            let allEqualsO = board[row].every(x=>x==='O')            
        }

        if (allEqualsX || allEqualsO) {
            console.log(`Player ${allEqualsX ? 'X': 'O'} wins!`);
        }
    }
}

solve(["0 1",
"0 0",
"0 2", 
"2 0",
"1 0",
"1 1",
"1 2",
"2 2",
"2 1",
"0 0"]
)