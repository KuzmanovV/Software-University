class Restaurant {
    constructor(budgetMoney) {
        this.budgetMoney = budgetMoney;
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }

    loadProducts(input) {
        let result = '';

        input.forEach(element => {
            let [product, qty, totalPrice] = element.split(' ');

            if (totalPrice <= this.budgetMoney) {
                if (!this.stockProducts[product]) {
                    this.stockProducts[product] = 0;
                }

                this.stockProducts[product] += Number(qty);
                result += `Successfully loaded ${qty} ${product}\n`
            } else {
                result += `There was not enough money to load ${qty} ${product}`
            }

        });

        return result;
    }

    addToMenu(input) {
        let [meal, products, price] = input;

        if (!this.menu[meal]) {
            this.menu[meal] = { products, price };

            if (Object.keys(this.menu).length == 1) {
                return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`
            } else {
                return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`
            }
        }

        return `The ${meal} is already in our menu, try something different.`
    }

    showTheMenu() {
        if (!Object.keys(this.menu).length) {
            return `Our menu is not ready yet, please come later...`
        }

        let result = '';
        for (const key in this.menu) {
            result += `${key} - $ ${key[price]}\n`
        }
        return result;
    }

    makeTheOrder(meal) {
        if (!this.menu[meal]) {
            return `There is not ${meal} yet in our menu, do you want to order something else?`
        }

        let areEnoughProducts = true;
        this.menu[meal][products].forEach(productTuple => {
            let product = productTuple.split(' ')[0];
            let qty = productTuple.split(' ')[1];
            if (qty<=this.stockProducts[product]) {
                //this.stockProducts[product]-=qty;
            } else {
                areEnoughProducts = false;
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`
            }
        });

        if (areEnoughProducts) {
            this.menu[meal][products].forEach(productTuple => {
                let product = productTuple.split(' ')[0];
                let qty = productTuple.split(' ')[1];
                this.stockProducts[product] -= qty;
            });

            this.budgetMoney+=this.menu[meal][price];
            return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal][price]}.`;
        }
    }
}

let kitchen = new Restaurant(1000);
console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));

console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));

console.log(kitchen.showTheMenu());

kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));





