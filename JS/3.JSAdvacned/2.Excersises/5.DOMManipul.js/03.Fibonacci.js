function getFibonator() {
    let num1 = -1;
    let num2 = 0;
    return function innerF() {
        result = Math.abs(num1 + num2);
        num1 = num2;
        num2 = result;
        return result;
    }    
}

let fib1 = getFibonator();
console.log(fib1()); // 1
console.log(fib1()); // 1
console.log(fib1()); // 2
console.log(fib1()); // 3
console.log(fib1()); // 5
console.log(fib1()); // 8
console.log(fib1()); // 13
