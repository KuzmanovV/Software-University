function AR(commands) {
    let inputNum=1;
    let output = [];
    for (const iterator of commands) {
        if (iterator==='add') {
            output.push(inputNum);
        }
        else{
            output.pop(inputNum);
        }
        inputNum++;
    }

    if (output.length===0) {
        return 'Empty'
    }
    else{
        return output.join('\n');
    }
}

console.log(AR(['add', 
'add', 
'add', 
'add']
));