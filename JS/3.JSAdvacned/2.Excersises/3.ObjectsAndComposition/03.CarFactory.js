function cf(input) {
    if (input.power >= 200) {
        power = 200;
        volume = 3500;
    } else if (input.power >= 120) {
        power = 120;
        volume = 2400;
    } else {
        power = 90;
        volume = 1800;
    }

    let engine = {
        power: power,
        volume: volume
    };

    let carriage = {
        type: input.carriage,
        color: input.color
    };

    if (input.wheelsize%2==1) {
        oneWheel=input.wheelsize;
    } else {
        oneWheel = input.wheelsize-1;
    }

    let wheels = [oneWheel, oneWheel, oneWheel, oneWheel];

    let output = {
        model: input.model,
        engine: engine,
        carriage: carriage,
        wheels: wheels
    };

    return output;
}

console.log(cf({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}
));