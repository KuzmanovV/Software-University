function radar(speed, area) {
    let limits = {
        'motorway': 130,
        'interstate': 90,
        'city': 50,
        'residential': 20
    }

    let severity = speed-limits[area];
    let status = ''
    
    if (severity<=0) {
        console.log(`Driving ${speed} km/h in a ${limits[area]} zone`);
    }  else if (severity<=20) {
        console.log(`The speed is ${severity} km/h faster than the allowed speed of ${limits[area]} - speeding`);
    } else if (severity<=40) {
        console.log(`The speed is ${severity} km/h faster than the allowed speed of ${limits[area]} - excessive speeding`);
    } else{
        console.log(`The speed is ${severity} km/h faster than the allowed speed of ${limits[area]} - reckless driving`);
    }
}

radar(40, 'city')
radar(21, 'residential')
radar(120, 'interstate')
radar(200, 'motorway')