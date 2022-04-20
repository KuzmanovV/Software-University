function mm(inputMat) {
    let sum = inputMat[0].reduce((a,b)=>a+b);
    let flag = true;
    for (const iterator of inputMat) {
        if (iterator.reduce((a,b)=>a+b) != sum) {
            flag = false;
        }
    }

    for (let i = 0; i < inputMat.length; i++) {
        let verticalSum = 0
        for (let j = 0; j < inputMat.length; j++) {
            verticalSum += inputMat[i][j];
        }
        
        if (verticalSum != sum) {
            flag = false;
        }
    }

    if (flag) {
        return 'true'
    }
    else {
        return 'false'
    }
}

console.log(mm([[4, 5, 6],
[6, 5, 4],
[5, 5, 5]]
));

console.log(mm([[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]
   ));