function solve() {
  let table = document.querySelectorAll('tbody');
  let [input, output] = Array.from(document.querySelectorAll('textarea'));
  let [generateBtn, buyBtn] = Array.from(document.querySelectorAll('Button'));

  generateBtn.addEventListener('click', generate);
  buyBtn.addEventListener('click', buying);

  function generate(e) {
    let furnitureArr = JSON.parse(input.value);
    
    furnitureArr.forEach(item => {
      let row = document.createElement('tr');
      let imgData = document.createElement('td');
      let imgE = document.createElement('img');
      imgE.src = item.img;
      imgData.appendChild(imgE);
      row.appendChild(imgData);

      let nameData = document.createElement('td');
      let nameE = document.createElement('p');
      nameE.textContent = item.name;
      nameData.appendChild(nameE);
      row.appendChild(nameData);

      let priceData = document.createElement('td');
      let decorData = document.createElement('td');
      let boxData  = document.createElement('td');

      let priceE = document.createElement('p');
      let decorE = document.createElement('p');
      let boxE = document.createElement('input');

      priceE.textContent = item.price;
      decorE.textContent = item.decFactor;
      boxE.type = 'checkbox';

      priceData.appendChild(priceE);
      decorData.appendChild(decorE);
      boxData.appendChild(boxE);

      row.appendChild(priceData);
      row.appendChild(decorData);
      row.appendChild(boxData);
      
      table.appendChild(row);
    })
  }


}