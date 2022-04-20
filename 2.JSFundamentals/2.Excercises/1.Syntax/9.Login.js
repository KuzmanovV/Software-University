function login(params) {
    let account = params.shift()
    let pass = account.split('').reverse().join('')

    for (let i = 0; i < params.length; i++) {
        if (pass === params[i]) {
            console.log(`User ${account} logged in.`);
        }
        else{
            if (i==3) {
                console.log(`User ${account} blocked!`);
                break;
            }

            console.log(`Incorrect password. Try again.`);
        }
    }
}

login(['momo','omom'])