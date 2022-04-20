function calculator() {
    let firstE;
    let secondE;
    let resultE;
    return {
        init: (selector1, selector2, resultSelector) => {
        firstE = document.querySelector(selector1);
        secondE = document.querySelector(selector2);
        resultE = document.querySelector(resultSelector);
      },
      add: () => {
        resultE.value = Number(firstE.value)+Number(secondE.value);
      },
      subtract: () => {
        resultE.value = Number(firstE.value)-Number(secondE.value);
      }
    }}

    let calculate = calculator();
    calculate.init('#num1', '#num2', '#result');