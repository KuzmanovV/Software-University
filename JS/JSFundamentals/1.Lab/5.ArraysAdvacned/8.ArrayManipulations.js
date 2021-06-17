function arrayManipulations(input) {
    let result = input.shift().split(' ').map(Number)

    for (const iterator of input) {
        switch (iterator.split(' ').shift()) {
            case 'Add':
                result.push(+iterator.pop())
                break;
            case 'Remove':
                result.splice(result.indexOf(iterator[0]), 1)
                break;
            case 'RemoveAt':
                result.splice(iterator[0], 1)
                break;
            case 'Insert':
                result.splice(iterator[1], 1, iterator[0])
                break;
            default:
                break;
        }
    }

    return result
}

console.log(arrayManipulations(['4 19 2 53 6 43',
    'Add 3',
    'Remove 2',
    'RemoveAt 1',
    'Insert 8 3']
));