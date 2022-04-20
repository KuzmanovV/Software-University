let pizzUni = {
    makeAnOrder: function (obj) {

        if (!obj.orderedPizza) {
            throw new Error('You must order at least 1 Pizza to finish the order.');
        } else {
            let result = `You just ordered ${obj.orderedPizza}`
            if (obj.orderedDrink) {
                result += ` and ${obj.orderedDrink}.`
            }
            return result;
        }
    },

    getRemainingWork: function (statusArr) {

        const remainingArr = statusArr.filter(s => s.status != 'ready');

        if (remainingArr.length > 0) {

            let pizzaNames = remainingArr.map(p => p.pizzaName).join(', ')
            let pizzasLeft = `The following pizzas are still preparing: ${pizzaNames}.`

            return pizzasLeft;
        } else {
            return 'All orders are complete!'
        }

    },

    orderType: function (totalSum, typeOfOrder) {
        if (typeOfOrder === 'Carry Out') {
            totalSum -= totalSum * 0.1;

            return totalSum;
        } else if (typeOfOrder === 'Delivery') {

            return totalSum;
        }
    }
}



let { assert } = require('chai');

describe("Tests …", function () {
    describe("makeAnOrder …", function () {
        it("Throws error", function () {
            assert.throw(() => pizzUni.makeAnOrder({}));
        });
        it("If ordered only pizza", function () {
            let obj = {
                orderedPizza: 'Margarita',
                //orderedDrink: 'beer'
            }

            assert.equal(pizzUni.makeAnOrder(obj), `You just ordered ${obj.orderedPizza}`);
        });
        it("If ordered pizza and drink", function () {
            let obj = {
                orderedPizza: 'Margarita',
                orderedDrink: 'beer'
            }

            assert.equal(pizzUni.makeAnOrder(obj), `You just ordered ${obj.orderedPizza} and ${obj.orderedDrink}.`);
        });
    });
    describe("getRemainingWork …", function () {
        it("Returns pizzas with status preparing if 1 not ready", function () {
            let statusArr = [{ pizzaName: 'Napoly', status: 'ready' }, { pizzaName: 'Margaritta', status: 'preparing' }];

            assert.equal(pizzUni.getRemainingWork(statusArr), `The following pizzas are still preparing: Margaritta.`);
        });
        it("Returns pizzas with status preparing if 2 not ready", function () {
            let statusArr = [{ pizzaName: 'Napoly', status: 'preparing' }, { pizzaName: 'Margaritta', status: 'preparing' }];

            assert.equal(pizzUni.getRemainingWork(statusArr), `The following pizzas are still preparing: Napoly, Margaritta.`);
        });
        it("Returns message if all ready", function () {
            let statusArr = [{ pizzaName: 'Napoly', status: 'ready' }, { pizzaName: 'Margaritta', status: 'ready' }];

            assert.equal(pizzUni.getRemainingWork(statusArr), 'All orders are complete!');
        });
        it("Returns message if empty arr", function () {
            let statusArr = [];

            assert.equal(pizzUni.getRemainingWork(statusArr), 'All orders are complete!');
        });
    });
    describe('orderType(totalSum, typeOfOrder)', ()=>{
        it('Should return total with 10% discount if type of order is Carry out', ()=>{
            assert.equal(pizzUni.orderType(100, 'Carry Out'), 90);
        });
        it('Should return total wt discount if type of order is Delivery', ()=>{
            assert.equal(pizzUni.orderType(100, 'Delivery'), 100);
        });
    })
});
