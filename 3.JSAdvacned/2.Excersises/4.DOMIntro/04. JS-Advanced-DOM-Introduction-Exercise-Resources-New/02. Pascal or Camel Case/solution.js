function solve() {
  let textElement = document.getElementById("text").value.toLowerCase().split(' ');
  let textConvention = document.getElementById('naming-convention').value
  let result = document.getElementById("result");

  let resultString = '';
  if (textConvention == 'Camel Case') {
    resultString=textElement[0];
    for (let i = 1; i < textElement.length; i++) {
      resultString += textElement[i][0].toUpperCase() + textElement[i].slice(1);
    }
    result.textContent = resultString;
  } else if (textConvention == 'Pascal Case') {
    for (let i = 0; i < textElement.length; i++) {
      resultString += textElement[i][0].toUpperCase() + textElement[i].slice(1);
    }
    result.textContent = resultString;
  } else {
    result.textContent = 'Error!';
  }
}

