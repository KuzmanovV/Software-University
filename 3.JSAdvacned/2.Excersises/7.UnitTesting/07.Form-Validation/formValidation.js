function validate() {
    let usernamePattern = /^[a-zA-Z]{3,20}$/gm;
    let passwordPattern = /^[\w]{5,15}$/gm;
    let mailPattern = /^[\w]+@[\w]+\.[\w]+$/gm;

    let isValid = true;
    let isChecked = false;

    let sbmButton = document.getElementById('submit');
    sbmButton.addEventListener('click', (e) => {
        e.preventDefault();

        let usernameField = document.getElementById('username');
        if (!usernamePattern.test(usernameField.value)) {
            usernameField.style.borderColor = 'red';
            isValid = false;
        } else {
            usernameField.style.border = 'none';
        }

        let confPasswordField = document.getElementById('confirm-password');
        let passwordField = document.getElementById('password');
        if (!passwordPattern.test(passwordField.value) 
        && !passwordPattern.test(confPasswordField.value)
        || confPasswordField.value != passwordField.value) {
            passwordField.style.borderColor = 'red';
            confPasswordField.style.borderColor = 'red';
            isValid = false;
        } else {
            passwordField.style.border = 'none';
            confPasswordField.style.border = 'none';
        }

        let mailField = document.getElementById('email');
        if (!mailPattern.test(mailField.value)) {
            mailField.style.borderColor = 'red';
            isValid = false;
        } else {
            mailField.style.border = 'none';
        }

        let validDiv = document.getElementById('valid');
        if (isValid) {
            validDiv.style.display = 'block';
        }
        else {
            validDiv.style.display = 'none';
        }

        if (isChecked) {
            let companyNumber = document.getElementById(companyNumber)
            if (Number(companyNumber.value) < 1000 || Number(companyNumber.value) > 9999) {
                companyNumber.style.borderColor = 'red';
                isValid = false;
            } else {
                companyNumber.style.border = 'none';
            }
        }
    })

    document.getElementById('company').addEventListener('change', (e) => {
        let companyField = document.getElementById('companyInfo');
        if (e.target.checked) {
            companyField.style.display = 'block';
            isChecked = true;
        }
        else {
            companyField.style.display = 'none';
        }
    });
}
