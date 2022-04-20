function loadingBar(input) {
    let scroll = ''
    for (let i = 0; i < input / 10; i++) {
        scroll += '%'
    }
    for (let i = input/10; i < 10; i++) {
        scroll += '.'
    }

    if (input === 100) {
        return `100% Complete!\n[%%%%%%%%%%]`
    } else if (input===0){
        return `${input}% [..........]\nStill loading...`
    } else {
        return `${input}% [${scroll}]\nStill loading...`
    }
}

console.log(loadingBar(0));
console.log(loadingBar(50));
console.log(loadingBar(100));
