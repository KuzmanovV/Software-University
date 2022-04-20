function extractText() {
let liElements = [...document.getElementsByTagName('li')].map(e=>e.textContent).join('\n');
document.getElementById('result').value = liElements
}