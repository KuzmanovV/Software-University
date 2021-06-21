function bombNumbers(input, special) {
    let bomb = special[0]
    let power = special[1]
    let index = input.indexOf(bomb)
    
    while (input.includes(bomb)) {
        input.splice(index,1)
        
        let index = input.indexOf(bomb)

    }

    return input
}

console.log(bombNumbers([1, 2, 2, 4, 2, 2, 2, 9], [4, 2]));