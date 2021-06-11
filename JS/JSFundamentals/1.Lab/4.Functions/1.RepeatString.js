function repeatString(inputString, n) {
    let result = ''

    for (let i = 0; i < +n; i++) {
        result += inputString
    }
    
    console.log(result);
}

repeatString('abc', 3)