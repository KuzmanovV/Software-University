function ttw(steps, footprint, speed) {
    let distanceInM = footprint * steps;
    let rests = Math.floor(distanceInM / 500);
    let time = distanceInM / 1000 / speed + rests / 60;
    let hours = Math.floor(time / 60);
    time = (time - hours) * 60;
    let minuts = Math.floor(time);
    let secunds = (time - minuts) * 60;
    let hoursString = '0' + hours;
    let minutsString = '0' + minuts;
    let secundssString = '0' + secunds.toFixed(0);
    console.log(`${hoursString.slice(-2)}:${minutsString.slice(-2)}:${secundssString.slice(-2)}`);
}

ttw(4000, 0.60, 5)
console.log(`-------------`);
ttw(2564, 0.70, 5.5)