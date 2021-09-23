function cf(input) {
   function getEngine(power) {
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
   
       return engine = {
           power,
           volume
       };
   }

    let carriage = {
        type: input.carriage,
        color: input.color
    };

    if (input.wheelsize%2==1) {
        oneWheel=input.wheelsize;
    } else {
        oneWheel = input.wheelsize-1;
    }

    let wheels = [];
    wheels.fill(input.wheelsize,0,4)

    let output = {
        model: input.model,
        engine: getEngine(input.power),
        carriage,
        wheels
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