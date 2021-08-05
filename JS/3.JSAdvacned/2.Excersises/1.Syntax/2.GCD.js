function divisor(a, b) {
    let gcd = 1;
    let greater = Math.max(a, b);
    let smaller = 0;

    if (greater = a) {
        smaller = b
    } else {
        smaller = a
    }

    for (let i = 1; i <= smaller; i++) {
        if (smaller % i == 0 && greater % i == 0) {
            gcd = i;
        }
    }

    console.log(gcd);
}

divisor(2154, 458)