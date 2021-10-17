class Restaurant{
    constructor (budgetMoney){
        this.budgetMoney = budgetMoney;
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }

    loadProducts(input){
        let result = '';

        input.forEach(element => {
            let [product, qty, totalPrice] = element.split(' ');

            if (totalPrice<=this.budgetMoney) {
                if (!this.stockProducts[product]) {
                    this.stockProducts[product] = 0;
                }

                this.stockProducts[product] += Number(qty);
                result+= `Successfully loaded ${qty} ${product}\n`
            } else{
                result+=`There was not enough money to load ${qty} ${product}`
            }

        });

        return result;
    }
}

let kitchen = new Restaurant(1000);
console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));
