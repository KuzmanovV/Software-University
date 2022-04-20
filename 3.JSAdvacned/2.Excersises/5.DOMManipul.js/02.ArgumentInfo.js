function ai(...args) {
    let outputTypes = {};
    let outputValues = {};
    args.forEach(arg => {
        let slicedArg = arg.slice(0, 10);
        if (Number(arg) || arg === 0) {
            outputTypes['number'] = arg;
            outputValues['number']++;
        } else if (slicedArg == 'function ()') {
            outputTypes['function'] = arg;
            outputValues['function']++;
        } else {
            outputTypes['string'] = arg;
            outputValues['string']++;
        }
    });

    console.log(outputTypes, outputValues);
}

ai('cat', 42, function () { console.log('Hello world!'); })