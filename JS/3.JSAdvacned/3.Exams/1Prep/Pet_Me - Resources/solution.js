function solve() {
    let addButton = document.querySelector('#container button');
    let nameIE = document.querySelector('input[placeholder="Name"]');
    let ageIE = document.querySelector('input[placeholder="Age"]');
    let kindIE = document.querySelector('input[placeholder="Kind"]');
    let ownerIE = document.querySelector('input[placeholder="Current Owner"]');
    let placeForPetAdoption = document.querySelector('#adoption ul');
    let newHomePlace = document.querySelector(('#adopted ul'))


    addButton.addEventListener('click', (e) => {
        e.preventDefault();

        if (!nameIE.value || !kindIE.value
            || !ownerIE.value || !ageIE.value
            || Number.isNaN(Number(ageIE.value))) {
            return;
        }

        let strong1 = document.createElement('strong');
        strong1.textContent = nameIE.value;
        let text1 = document.createTextNode(" is a ");
        let text2 = document.createTextNode(" year old ");
        let strong2 = document.createElement('strong');
        strong2.textContent = ageIE.value;
        let strong3 = document.createElement('strong');
        strong3.textContent = kindIE.value;
        let pE = document.createElement('p');
        pE.appendChild(strong1);
        pE.appendChild(text1);
        pE.appendChild(strong2);
        pE.appendChild(text2);
        pE.appendChild(strong3);

        let spanE = document.createElement('span');
        spanE.textContent = `Owner: ${ownerIE.value}`;

        let btnE = document.createElement('button');
        btnE.textContent = 'Contact with owner';

        let liE = document.createElement('li');
        liE.appendChild(pE);
        liE.appendChild(spanE);
        liE.appendChild(btnE);

        placeForPetAdoption.appendChild(liE);

        nameIE.value = '';
        ageIE.value = '';
        kindIE.value = '';
        ownerIE.value = '';

        btnE.addEventListener('click', adopt);
        function adopt() {
            let inputE = document.createElement('input');
            inputE.classList.add('placeholder');
            inputE.placeholder = 'Enter your names';

            let btnTake = document.createElement('button');
            btnTake.textContent = 'Yes! I take it!'

            btnE.remove();

            let divE = document.createElement('div');
            divE.appendChild(inputE);
            divE.appendChild(btnTake);

            liE.appendChild(divE);



            btnTake.addEventListener('click', taken);

            function taken() {
                if (inputE.value.trim() == '') {
                    return;
                }

                newHomePlace.appendChild(liE);
                spanE.textContent = `New Owner: ${inputE.value}`;

                let btnCheck = document.createElement('button');
                btnCheck.textContent = 'Checked';
                liE.appendChild(btnCheck);
                
                divE.remove();
                btnTake.remove();

                btnCheck.addEventListener("click", ()=>{
                    liE.remove();
                })
            }
        }
    })
}

