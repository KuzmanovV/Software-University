function solution() {
    let recipes = {
        apple: { carbohydrate: 1, flavour: 2 },
        lemonade: { carbohydrate: 10, flavour: 20 },
        burger: { carbohydrate: 5, fat: 7, flavour: 3 },
        eggs: { protein: 5, fat: 1, flavour: 1 },
        turkey: { protein: 10, carbohydrate: 10, fat: 10, flavour: 10 },
    };

    let stock = { protein: 0, carbohydrate: 0, fat: 0, flavour: 0 };

    let commands = {
        restock: function (element, qty) {
            stock[element] += Number(qty);
            return `Success`;
        },
        prepare: function (recipe, qty) {
            let leftStock = {};
            for (const key in recipes[recipe]) {
                let left = stock[key] - Number(recipes[recipe][key]) * Number(qty);
                if (left < 0) {
                    return `Error: not enough ${key} in stock`
                }
                else {
                    leftStock[key] = left;
                }
            }
            
            Object.assign(stock, leftStock);
            return `Success`;
        },
        report: function(){
            return `protein=${stock.protein} carbohydrate=${stock.carbohydrate} fat=${stock.fat} flavour=${stock.flavour}`;
        },
    };

    return function control(inp) {
        let [command, recipe, qty] = inp.split(' ');
        return commands[command](recipe, qty);
    }
}


let manager = solution();
console.log(manager("restock flavour 50"));
console.log(manager('prepare lemonade 4'));
console.log(manager("restock carbohydrate 10"));
console.log(manager("restock flavour 10"));
console.log(manager("prepare apple 1"));
console.log(manager("restock fat 10"));
console.log(manager("prepare burger 1"));
console.log(manager("report"));
console.log(manager("restock flavour 50"));
console.log(manager("restock flavour 50"));