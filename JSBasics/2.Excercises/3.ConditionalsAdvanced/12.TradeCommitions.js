function commision(args) {
    let city = args[0];
    let sales = Number(args[1])
    let rate = 1

    switch (city) {
        case 'Sofia':
            if (sales >= 0 && sales <= 500)
                rate = 0.05
            else if (sales > 500 && sales <= 1000)
                rate = 0.07
            else if (sales > 1000 && sales <= 10000)
                rate = 0.08
            else if (sales > 10000)
                rate = 0.12
            else{
                console.log('error')
                return}
            break
        case 'Varna':
            if (sales >= 0 && sales <= 500)
                rate = 0.045
            else if (sales > 500 && sales <= 1000)
                rate = 0.075
            else if (sales > 1000 && sales <= 10000)
                rate = 0.1
            else if (sales > 10000)
                rate = 0.13
            else{
                console.log('error')
                return}
            break
        case 'Plovdiv':
            if (sales >= 0 && sales <= 500)
                rate = 0.055
            else if (sales > 500 && sales <= 1000)
                rate = 0.08
            else if (sales > 1000 && sales <= 10000)
                rate = 0.12
            else if (sales > 10000)
                rate = 0.145
            else{
                console.log('error')
                return}
            break
        default:
            console.log('error')
            return
            break
    }

    console.log((sales*rate).toFixed(2))
}

commision(["Sofia",
    "1500"])
