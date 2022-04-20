function ladybugs(input) {
    let field = []
    let length = input.shift()
    let indexes = input.shift()

    let indexesArr = indexes.split(' ')

    for (let i = 0; i < length; i++) {
        field.push(0)
    }

    for (let i = 0; i < indexesArr.length; i++) {
       if (indexesArr[i]>=0 && indexesArr[i]<length) {
        field[indexesArr[i]] = 1
       }
    }

    for (let i = 0; i < input.length; i++) {
        const cmd = input[i].split(' ')
        let indexToMove = cmd[0]
        let direction = cmd[1]
        let mooveLength = cmd[2]

        if (indexToMove >= 0 && indexToMove < length && field[indexToMove] == 1) {
            field[indexToMove] = 0

            do {
                if (direction == 'right') {
                    indexToMove += +mooveLength
                } else {
                    indexToMove -= +mooveLength
                }
            } while (indexToMove >= 0 && indexToMove < length && field[indexToMove] == 1);

            if (field[indexToMove]===0) {
                field[indexToMove]=1
            }
        }
    }

    console.log(field.join(' '));
}

ladybugs([ 3, '0 1 2',
'0 right 1',
'2 right 1' ]

)