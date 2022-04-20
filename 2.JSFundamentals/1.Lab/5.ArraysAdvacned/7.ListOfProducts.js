function listOfProducts(products) {
    let sortedList =  products.sort()

    let result = ''
    for (let i=1; i<=sortedList.length; i++) {
        result+= `${i}.${sortedList[i-1]}\n`
    }

    return result
}

console.log(listOfProducts(["Potatoes", "Tomatoes", "Onions", "Apples"]));