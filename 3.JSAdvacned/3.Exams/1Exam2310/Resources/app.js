window.addEventListener('load', solve);

function solve() {
    let addBtn = document.getElementById('add-btn');
    let genreI = document.getElementById('genre');
    let nameI = document.getElementById('name');
    let authorI = document.getElementById('author');
    let dateI = document.getElementById('date');
    let collectionToPut = document.querySelector(`#all-hits .all-hits-container`);
    let likesE = document.querySelector('#total-likes div p')
    let totalLikes = 0;

    addBtn.addEventListener('click', (e) => {
        e.preventDefault();

        if (genreI.value=='' 
        || nameI.value=='' 
        || authorI.value=='' 
        || dateI.value=='') {
            return;
        }

        let imgE = document.createElement('img');
        imgE.scr = `./static/img/img.png`;

        let h2E1 = document.createElement('h2');
        h2E1.textContent = `Genre: ${genreI.value}`;

        let h2E2 = document.createElement('h2');
        h2E2.textContent = `Name: ${nameI.value}`;

        let h2E3 = document.createElement('h2');
        h2E3.textContent = `Author: ${authorI.value}`;

        let h2E4 = document.createElement('h2');
        h2E4.textContent = `Date: ${dateI.value}`;

        let btnS = document.createElement('button');
        btnS.classList.add('save-btn');
        btnS.textContent = `Save song`;

        let btnL = document.createElement('button');
        btnL.classList.add('like-btn');
        btnL.textContent = `Like song`;

        let btnD = document.createElement('button');
        btnD.classList.add('delete-btn');
        btnD.textContent = `Delete`;

        let divE = document.createElement('div');
        divE.innerHTML = '<img src="./static/img/img.png">';
        divE.appendChild(h2E1);
        divE.appendChild(h2E2);
        divE.appendChild(h2E3);
        divE.appendChild(h2E4);
        divE.appendChild(btnS);
        divE.appendChild(btnL);
        divE.appendChild(btnD);
        collectionToPut.appendChild(divE);

        h2E1.textContent='';
        h2E2.textContent='';
        h2E3.textContent='';
        h2E4.textContent='';

        btnL.addEventListener('click', likePressed);

        function likePressed() {
            totalLikes++;
            
            likesE.textContent = `Total Likes: ${totalLikes}`;
        }
    })
}