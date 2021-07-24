function calc(a, b, operator) {
    switch (operator) {
        case 'multiply':
            let result = (a, b) => a * b
            return result(a, b)
            break;
        case 'divide':
            let devide = (a, b) => a / b
            return result(a, b)
            break;
        /*case 'add':
            let result = (a, b) => a + b
            return result(a, b)
            break;
        case 'subtract':
            let result = (a, b) => a - b
            return result(a, b)
            break;*/
        default:
            break;
    }
}

console.log(calc(5,
    5,
    'multiply'));
