function sa(inputArr, command) {
    if (command == 'asc') {
        return output = inputArr.sort((a, b) => (a-b));
    }
    else {
        return output = inputArr.sort((a, b) => (b-a));
    }
}

console.log(sa([14, 7, 17, 6, 8], 'asc'));
console.log(sa([14, 7, 17, 6, 8], 'desc'));
