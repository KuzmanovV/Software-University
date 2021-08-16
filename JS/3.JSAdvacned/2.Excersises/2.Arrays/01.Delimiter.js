function delimiter(inputArr, deli) {
    
    let output = ''
    for (let i = 0; i < inputArr.length-1; i++) {
        output+=inputArr[i]+deli;        
    }

    output+=inputArr[inputArr.length-1];

    console.log(output);
}

delimiter(['One', 
'Two', 
'Three', 
'Four', 
'Five'], 
'-')