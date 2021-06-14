function validator(pass) {
    function validLength(pass) {
        return pass.length >= 6 && pass.length <= 10 ? true : false
    }

    function validLettersAndDigits(pass) {
        let isValid = true
        for (let i = 0; i < pass.length; i++) {
            let code = pass.charCodeAt(i)
            let isValid = code > 47 && code < 58
                || code > 64 && code < 91
                || code > 96 && code < 123 ? true : false
            if (!isValid) {
                return false
            }
        }

       return true
    }

    function validNumberOfDigits(pass) {
        let numberOfDigits = 0

        for (let i = 0; i < pass.length; i++) {
            let code = pass.charCodeAt(i)
            if (code > 47 && code < 58)
                numberOfDigits++
        }

        return numberOfDigits >= 2 ? true : false
    }

    let result = ''
    if (!validLength(pass)) {
        result = `Password must be between 6 and 10 characters\n`
    }

    if (!validLettersAndDigits(pass)) {
        result += `Password must consist only of letters and digits\n`
    }

    if (!validNumberOfDigits(pass)) {
        result += `Password must have at least 2 digits\n`
    }

    if (validLength(pass) && validLettersAndDigits(pass) && validNumberOfDigits(pass)) {
        result = `Password is valid`
    }

    return result
}

console.log(validator('logIn'));