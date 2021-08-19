function extract(inputArr) {
    let current = inputArr[0];
    let output = [current];
    for (let i = 1; i < inputArr.length; i++) {
        if (inputArr[i]>=current) {
            current=inputArr[i];
            output.push(current);
        }
    }

    return output;
}

console.log(extract([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    ));