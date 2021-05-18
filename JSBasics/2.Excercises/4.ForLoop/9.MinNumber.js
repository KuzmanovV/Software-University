function minNumber(input){
    let minNum = Number(input[0]);
    for(let i=1; i<=input.length; i++){
    
        if(Number(input[i])<=minNumber)
minNum=Number(input[i])
}

console.log(minNum)
}

minNumber(["3",
"-10",
"20",
"-30"])