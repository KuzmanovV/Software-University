function rotateArray(inputArr, times) {
    for (let i = 0; i < times; i++) {
        inputArr.unshift(inputArr.pop());        
    }

    let output = '';
    
    for (const iterator of inputArr) {
        output+=iterator+' ';
    }

    console.log(output);
}

rotateArray(['1', 
'2', 
'3', 
'4'], 
2)