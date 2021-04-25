function record(input){
    let oldRecord = Number(input[0])
    let distance = Number(input[1])
    let speed = Number(input[2])
    let time1 = distance*speed
    let time2 = Math.floor(distance/15)*12.5
    let time = (time1+time2).toFixed(2)
    if(time<oldRecord)
        console.log(`Yes, he succeeded! The new world record is ${time} seconds.`)
    else
        console.log(`No, he failed! He was ${(time-oldRecord).toFixed(2)} seconds slower.`)
}

record(["55555.67",
"3017",
"5.03"])

