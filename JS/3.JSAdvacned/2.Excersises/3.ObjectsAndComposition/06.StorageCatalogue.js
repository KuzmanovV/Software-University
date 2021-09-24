function sc(arr) {

    function deleteIndent(arr) {
        let deletedResult = [];
        for (const iterator of arr) {
            let tokens = iterator.split(' : ');
            deletedResult.push(`${tokens[0]}: ${tokens[1]}`)
        }
        return deletedResult
    }
    
    let sortedResult = deleteIndent(arr).sort();

    let finalResult = {}
    for (const iterator of sortedResult) {
        if (!finalResult[iterator[0][0]]) {
            finalResult[iterator[0][0]] = [];
        }

        finalResult[iterator[0][0]].push(iterator);
    }

    for (const key in finalResult) {
        console.log(key);
        for (const iterator of finalResult[key]) {
            console.log(`   ${iterator}`);
        }
    }
}

sc(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']
)