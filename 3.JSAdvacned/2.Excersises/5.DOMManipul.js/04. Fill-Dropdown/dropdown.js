function addItem() {
let textE = document.getElementById('newItemText');
let valueE = document.getElementById('newItemValue');

let option = document.createElement('option');
option.textContent = textE.value;
option.value = valueE.value;

document.getElementById('menu').appendChild(option);

textE.value = '';
valueE.value = '';
}