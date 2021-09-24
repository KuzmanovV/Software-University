function t(arr) {
    let resultArr = [];
    for (let i = 1; i < arr.length; i++) {
        let tokens = arr[i].substring(2, arr[i].length-2).split(' | ');
        let obj = {
            Town: tokens[0],
            Latitude: Number(Number(tokens[1]).toFixed(2)),
            Longitude: Number(Number(tokens[2]).toFixed(2))
        }
        resultArr.push(obj);
    }

    return JSONresult = JSON.stringify(resultArr);
}

console.log(t(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
));
