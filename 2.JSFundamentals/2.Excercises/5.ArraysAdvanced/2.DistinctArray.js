function distinct(input) {
    let output = []

    for (let number of input) {
        if (!output.includes(number)) {
            output.push(number)
        }
    }

    return output.join(' ')
}

console.log(distinct([7, 8, 9, 7, 2, 3, 4, 1, 2]));