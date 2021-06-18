function arrayManipulations(input) {
    let result = input
        .shift()
        .split(' ')
        .map(Number)

    for (const part of input) {
        let [cmd, firstNum, secondNum] = part.split(' ')
        switch (cmd) {
            case 'Add':
                result.push(+firstNum)
                break;
            case 'Remove':
                result = result.filter(x=>x!==+firstNum)
                break;
            case 'RemoveAt':
                result.splice(+firstNum, 1)
                break;
            case 'Insert':
                result.splice(+secondNum, 0, +firstNum)
                break;
            default:
                break;
        }
    }

    return result.join(' ')
}

console.log(arrayManipulations(['4 19 2 53 6 43',
    'Add 3',
    'Remove 2',
    'RemoveAt 1',
    'Insert 8 3']
));