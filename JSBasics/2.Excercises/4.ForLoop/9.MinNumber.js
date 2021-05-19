function minNumber(input) {
    let n = Number(input[0])
    let minNum = Number(input[1]);
    for (let i = 2; i <= n; i++) {
        if (Number(input[i]) < minNum)
            minNum = Number(input[i])
    }
    console.log(minNum)
}

minNumber(["3",
    "-10",
    "20",
    "-30"])