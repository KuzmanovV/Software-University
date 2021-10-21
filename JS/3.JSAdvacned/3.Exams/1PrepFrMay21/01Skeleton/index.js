function solve() {
    let [nameE, dateE] = Array.from(document.querySelectorAll('input'));
    let moduleE = document.querySelector('select[name="lecture-module"]');
    let button = document.querySelector('.form-control button');

    button.addEventListener('click', (e)=>{
        e.preventDefault();
        if (nameE.value==='' || dateE.value ==='' || moduleE.value ==="Select module") {
            return;
        }

        let lectureE = document.createElement('h4');
        lectureE.textContent = `${nameE.value} - ${formatDate(dateE.value)}`;

        let delButton = document.createElement('button');
        delButton.classList.add('red');
        delButton.textContent = 'Del';

        let LiE = document.createElement('li');
        LiE.classList.add('flex');
        LiE.appendChild(lectureE);
        LiE.appendChild(delButton);

        let ulE = document.createElement('ul');
        ulE.appendChild(LiE);

        let h3E = document.createElement('h3');
        h3E.textContent = `${moduleE.value.toUpperCase()}-MODULE`;

        let divE = document.createElement('div');
        divE.classList.add('module');
        divE.appendChild(h3E);
        divE.appendChild(ulE);
       
        let modulsE = document.querySelector('.modules');
        modulsE.appendChild(divE);
    })

    function formatDate(dateInput) {
        let [date, time] = dateInput.split('T');
        date = date.replace(/-/g,'/');
        return `${date} - ${time}`;
    }
};