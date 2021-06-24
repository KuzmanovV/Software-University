function manipulator(input, cmd) {
    for (const iterator of cmd) {
        if (iterator === 'print') {
            break
        }

        let commandArr = iterator.split(' ')
        let command = commandArr[0]

        switch (command) {
            case 'add':
                input.splice(+commandArr[1], 0, +commandArr[2])
                break;

            case 'remove':
                input.splice(+commandArr[1], 1)
                break;
            case 'shift':
                for (let i = 0; i < +commandArr[1]; i++) {
                    const toShift = input.shift();
                    input.push(toShift)
                }
                break;
            case 'sumPairs':
                let output = []
                for (let i = 0; i < input.length; i += 2) {
                    if (i + 1 < input.length) {
                        output.push(input[i] + input[i + 1])
                    } else {
                        output.push(input[i])
                    }
                }
                input = output
                break;
            case 'addMany':
                let forAdd = commandArr.slice(2).map(Number)
                for (const iterator of forAdd) {
                    input.splice(+commandArr[1], 0, iterator)
                    commandArr[1]++
                }
                break;
            case 'contains':
                console.log(input.indexOf(+commandArr[1]))
                break;
            default:
                break;
        }
    }

    console.log(`[ ${input.join(', ')} ]`)
}

manipulator([2, 2, 4, 2, 4],
    ["add 1 4", "sumPairs", "print"]);