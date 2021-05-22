function specialNumbers(args) {
    let N = Number(args[0])
    let printLine = ''

    for (let i = 1111; i <= 9999; i++) {
        let string = ' ' + i
        first = Number(string[1])
        second = Number(string[2])
        third = Number(string[3])
        fourth = Number(string[4])

        if (N % first === 0 && N % second === 0 && N % third === 0 && N % fourth === 0)
            printLine += `${i} `
    }
    console.log(printLine)
}

specialNumbers(["3"])