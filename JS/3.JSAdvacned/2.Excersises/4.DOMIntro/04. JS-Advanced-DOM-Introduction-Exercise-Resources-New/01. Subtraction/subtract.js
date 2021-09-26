function subtract() {
    let result = document.getElementById("result");
    let first = Number(document.getElementById("firstNumber").value);
    let second = Number(document.getElementById("secondNumber").value);
    result.textContent = (first-second).toString();
}