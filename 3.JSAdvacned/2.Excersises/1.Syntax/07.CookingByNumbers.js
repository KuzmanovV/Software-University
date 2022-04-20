function cooking(inputNumber, a, b, c, d, e) {
    Number(inputNumber);
    let commands = [a, b, c, d, e];
    for (const iterator of commands) {
        switch (iterator) {
            case 'chop':
                inputNumber /= 2;
                break;
            case 'dice':
                inputNumber = Math.sqrt(inputNumber);
                break;
            case 'spice':
                inputNumber += 1;
                break;
            case 'bake':
                inputNumber *= 3
                break;
            case 'fillet':
                inputNumber *= .8;
                break;
            default:
                break;
        }
        console.log(inputNumber);
    }
}

cooking('32', 'chop', 'chop', 'chop', 'chop', 'chop')

cooking('9', 'dice', 'spice', 'chop', 'bake', 'fillet')