function nth(inputArr, step) {
    let output=[];
    for (let i = 0; i < inputArr.length; i+=step) {
        output.push(inputArr[i]);
    }
    return output;
}
console.log(nth(['dsa',
'asd', 
'test', 
'tset'], 
2
));