function solve() {
  let table = document.querySelector('tbody');
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
      let boxData = document.createElement('td');

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

  function buying() {
    let furniture = Array
      .from(document.querySelectorAll('input[type = "checkbox"]:checked'))
      .map(b => b.parentElement.parentElement)
      .map(r => ({
        name: r.children[1].textContent,
        price: r.children[2].textContent,
        decFactor: r.children[3].textContent,
      }));

      let total = 0;
      let avDecFactor = 0;
      let namesArr = [];
      for (const item of furniture) {
        total+=Number(item.price);
        avDecFactor+=Number(item.decFactor);
        namesArr.push(item.name);
      };

      output.value = `Bought furniture: ${namesArr.join(', ')}
Total price: ${total.toFixed(2)}
Average decoration factor: ${avDecFactor/namesArr.length}`;
  }
}