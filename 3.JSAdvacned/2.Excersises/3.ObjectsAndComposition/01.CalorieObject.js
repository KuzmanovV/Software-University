function co(inputArr) {
    let output = {};
    for (let i = 0; i < inputArr.length-1; i+=2) {
        output[inputArr[i]]=Number(inputArr[i+1]);
    }

    console.log(output);
}

co(['Yoghurt', '48', 'Rise', '138', 'Apple', '52'])