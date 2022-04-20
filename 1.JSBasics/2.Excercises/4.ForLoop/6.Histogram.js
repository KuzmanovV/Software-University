function histogram(input) {
    let n = Number(input[0])
    let p1Count = 0
    let p2Count = 0
    let p3Count = 0
    let p4Count = 0
    let p5Count = 0

    for (let i = 1; i <= n; i++) {
        if(Number(input[i])<200)
        p1Count++
        else if(Number(input[i])>=200 && Number(input[i])<400)
        p2Count++
        else if(Number(input[i])>=400 && Number(input[i])<600)
        p3Count++
        else if(Number(input[i])>=600 && Number(input[i])<800)
        p4Count++
        else
        p5Count++
    }

    console.log(`${(p1Count*100.0/n).toFixed(2)}%`)
    console.log(`${(p2Count*100.0/n).toFixed(2)}%`)
    console.log(`${(p3Count*100.0/n).toFixed(2)}%`)
    console.log(`${(p4Count*100.0/n).toFixed(2)}%`)
    console.log(`${(p5Count*100.0/n).toFixed(2)}%`)
}

histogram(["3",
    "1",
    "2",
    "999"])
