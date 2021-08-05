function sm(num) {
    let same = true; 
    let sum=0;   
    let stringOfNums = num.toString();
    for (const number of stringOfNums) {
        for (const secondNumber of stringOfNums) {
            if (number!=secondNumber) {
                same=false;
            }
            sum+=Number(secondNumber)
        }
    }

    console.log(same);
    console.log(sum/stringOfNums.length);
}

sm(2222222)

sm(1234)