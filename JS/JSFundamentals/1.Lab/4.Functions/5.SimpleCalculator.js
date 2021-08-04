function calc(a, b, operator) {
    switch (operator) {
        case 'multiply':
            let multiply = (a, b) => a * b
            return multiply(a, b)
            break;
        case 'divide':
            let divide = (a, b) => a / b
            return divide(a, b)
            break;
        case 'add':
            let add = (a, b) => a + b
            return add(a, b)
            break;
        case 'subtract':
            let sub = (a, b) => a - b
            return sub(a, b)
            break;
        default:
            break;
    }
}

console.log(calc(5,
    5,
    'multiply'));
