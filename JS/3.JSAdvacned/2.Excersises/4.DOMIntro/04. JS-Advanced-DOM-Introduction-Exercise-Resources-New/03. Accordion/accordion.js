function toggle() {
    let buttonElement = document.getElementsByClassName('button')[0];
    let textElement = document.querySelector('#extra');

    buttonElement.textContent = buttonElement.textContent == 'More' ? 'Less' : 'More';
    textElement.style.display = textElement.style.display == 'none' || textElement.style.display == '' ? 'block' : 'none';
}