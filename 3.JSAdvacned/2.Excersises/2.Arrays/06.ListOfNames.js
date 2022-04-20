function solve(arr) {
    const result = arr.sort((a,b)=>a.localeCompare(b));

    arr.forEach((el,index) => {
        console.log(`${++index}.${el}`);
    });

    /*for (const iterator of result) {
        console.log(`${i}.${iterator}`);
        i++;
    }*/
}

solve(["John", "Bob", "Christina", "Ema"])