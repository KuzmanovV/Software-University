function ai(...args) {
    let output = [];

    args.forEach(element => {
        let type = typeof element;
        console.log(`${type}: ${element}`);
        
        if (!output[type]) {
            output[type] = 0;
        }
        output[type] ++;
    });

    let sortable = Object.entries(output);

    let sorted = sortable.sort((a, b) => b[1] - a[1]);

    sorted.forEach(element => {
        console.log(`${element[0]} = ${element[1]}`);
    });
}

//ai('cat', 42, function () { console.log('Hello world!'); })
ai({ name: 'bob'}, 3.333, 9.999)