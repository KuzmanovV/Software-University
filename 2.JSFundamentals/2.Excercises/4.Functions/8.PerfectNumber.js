function perfectNumber(input) {
    let sum = 0
    for (let i = 0; i <= input / 2; i++) {
        if (input % i === 0) {
            sum += i
        }
    }

    if (sum === input) {
        return `We have a perfect number!`
    } else {
        return `It's not so perfect.`
    }
}

console.log(perfectNumber(6));
console.log(perfectNumber(28));
console.log(perfectNumber(1236498));
