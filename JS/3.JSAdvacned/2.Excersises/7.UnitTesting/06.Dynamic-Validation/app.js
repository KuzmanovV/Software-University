function validate() {
    let inputField = document.getElementById('email');
    let pattern = /(^[a-z]+@[a-z]+\.[a-z]+$)/;

    inputField.addEventListener('change', () => {
        if (!pattern.test(inputField.value)) {
            inputField.classList.add('error');
        } else {
            inputField.classList.remove('error');
        }
    })
}