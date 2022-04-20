function price(input){
    let totalPrice = 7.61*input[0];
    let discount = totalPrice*0.18;
    console.log(`The final price is: ${totalPrice-discount} lv.`)
    console.log(`The discount is: ${discount} lv.`)
}

price([550]);