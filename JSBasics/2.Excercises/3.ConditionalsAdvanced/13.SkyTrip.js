function totalPrice(args) {
    let days = Number(args[0]);
    let room = args[1];
    let tip = args[2];
    let discounted = 1;
    let price = 18;

    switch (room) {
        case 'apartment':
            price = 25
            if (days < 10)
                discounted = .7;
            else if (days >= 10 && days <= 15)
                discounted = .65;
            else
                discounted = .5;
            break;
        case 'president apartment':
            price = 35
            if (days < 10)
                discounted = .9;
            else if (days >= 10 && days <= 15)
                discounted = .85;
            else
                discounted = .8;
            break;
    }

    let result = (days - 1) * price * discounted

    if (tip == 'positive')
        result *= 1.25
    else
        result *= .9

    console.log(result.toFixed(2))
}

totalPrice(["12",
"room for one person",
"positive"])