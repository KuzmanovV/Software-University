function mining(params) {
    let lv = 0;
    let bitcoins = 0
    let firstBitcoinDay = 0

    for (let i = 0; i < params.length; i++) {
        if ((i + 1) % 3 == 0) {
            params[i] *= .70
        }

        lv += params[i] * 67.51

        if (lv >= 11949.16) {
            let addedBitcoins = Math.floor((lv / 11949.16))
            lv -= addedBitcoins * 11949.16
            bitcoins+=addedBitcoins

            if (firstBitcoinDay == 0) {
                firstBitcoinDay = i+1
            }
        }
    }

    console.log(`Bought bitcoins: ${bitcoins}`);

    if (bitcoins!=0) {
        console.log(`Day of the first purchased bitcoin: ${firstBitcoinDay}`);
    }

    console.log(`Left money: ${lv.toFixed(2)} lv.`);
}

mining([3124.15, 504.212, 2511.124])