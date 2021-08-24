function lp(input) {
    let products = {};
    
    for (const iterator of input) {
        let [town, product, price] = iterator.split(' | ');
        price = Number(price);
        
        if (!products.hasOwnProperty(product)) {
            products[product] = {};
        }

        products[product][town] = price;
    }

    return products;
}

console.log(lp(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
));