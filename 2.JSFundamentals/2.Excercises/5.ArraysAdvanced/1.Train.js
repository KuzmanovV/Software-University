function train(input) {
    let wagonsArr = input.shift().split(' ').map(Number)
    let capacity=Number(input.shift())
    for (let cmd of input) {
        cmd = cmd.split(' ')

        if (cmd[0] === 'Add') {
            wagonsArr.push(+cmd[1])
        } else{
            for (let i=0; i<=wagonsArr.length; i++) {
                if (wagonsArr[i]+Number(cmd[0])<=capacity) {
                    wagonsArr[i]+=Number(cmd[0])
                    break
                }
            }
        }
    }

    return wagonsArr.join(' ')
}

console.log(train(['0 0 0 10 2 4',
'10',
'Add 10',
'10',
'10',
'10',
'8',
'6']));