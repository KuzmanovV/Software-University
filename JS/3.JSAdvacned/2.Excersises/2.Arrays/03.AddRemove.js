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

    let outputForPrint='';
    for (const iterator of output) {
        outputForPrint+=(iterator+'\n')
    }
    
    if (outputForPrint.length===0) {
        return 'Empty'
    }
    else{
        return outputForPrint;
    }
}

console.log(AR(['add', 
'add', 
'add', 
'add']
));