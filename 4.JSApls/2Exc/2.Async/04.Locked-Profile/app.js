async function lockedProfile() {
    const main = document.getElementById('main');
    
    const url = `http://localhost:3030/jsonstore/advanced/profiles`;
    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }
        const data = await res.json();
        console.log(data);

        let userCounter = 0;
        Object.values(data).forEach(e => {
            userCounter++;
            createCard(e, userCounter);
        });
        
        cardsRevealHidingLogic();
    } catch (error) {
        alert('Error!');
    }

    function createCard(e, userCounter) {
        const hr = document.createElement('hr');

        const mailLabel = document.createElement('label');
        mailLabel.textContent = 'Email:';

        const mailInput = document.createElement('input');
        mailInput.type = 'email';
        mailInput.name = 'user1Email';
        mailInput.value = e.email;
        mailInput.disabled = true;
        mailInput.readonly = true;

        const ageLabel = document.createElement('label');
        ageLabel.textContent = 'Email:';

        const ageInput = document.createElement('input');
        ageInput.type = 'email';
        ageInput.name = 'user1Age';
        ageInput.value = e.age;
        ageInput.disabled = true;
        ageInput.readonly = true;

        const idDiv = document.createElement('div');
        idDiv.id = `user${userCounter}HiddenFields`;

        idDiv.appendChild(hr);
        idDiv.appendChild(mailLabel);
        idDiv.appendChild(mailInput);
        idDiv.appendChild(ageLabel);
        idDiv.appendChild(ageInput);

        const img = document.createElement('img');
        img.src = './iconProfile2.png';
        img.classList.add('userIcon');

        const lockLabel = document.createElement('label');
        lockLabel.textContent = 'Lock';

        const lockRadio = document.createElement('input');
        lockRadio.type = 'radio';
        lockRadio.name = `user${userCounter}Locked`;
        lockRadio.value = 'lock';
        lockRadio.checked = true;

        const unlockLabel = document.createElement('label');
        unlockLabel.textContent = 'Unlock';

        const unlockRadio = document.createElement('input');
        unlockRadio.type = 'radio';
        unlockRadio.name = `user${userCounter}Locked`;
        unlockRadio.value = 'unlock';

        const upHr = document.createElement('hr');

        const usernameLabel = document.createElement('label');

        const usernameInput = document.createElement('input');
        usernameInput.type = 'text';
        usernameInput.name = `user${userCounter}Username`;
        usernameInput.value = e.username;
        usernameInput.disabled = true;
        usernameInput.readonly = true;

        const btn = document.createElement('button');
        btn.textContent = 'Show more';

        const profileDiv = document.createElement('div');
        profileDiv.classList.add('profile');
        profileDiv.appendChild(img);
        profileDiv.appendChild(lockLabel);
        profileDiv.appendChild(lockRadio);
        profileDiv.appendChild(unlockLabel);
        profileDiv.appendChild(unlockRadio);
        profileDiv.appendChild(upHr);
        profileDiv.appendChild(usernameLabel);
        profileDiv.appendChild(usernameInput);
        profileDiv.appendChild(idDiv);
        profileDiv.appendChild(btn);

        main.appendChild(profileDiv);
    }

    function cardsRevealHidingLogic() {
        main.addEventListener('click', e => {
            if (e.target.tagName == 'BUTTON') {
                let profile = e.target.parentElement;
                let isActive = profile.querySelector('input[type="radio"][value = "unlock"]').checked;

                if (isActive) {
                    let hidden = profile.querySelector('div');

                    if (e.target.textContent == 'Show more') {
                        hidden.style.display = 'block';
                        e.target.textContent = "Hide it";
                    } else {
                        hidden.style.display = '';
                        e.target.textContent = 'Show more';
                    }
                }
            }
        })
    }
}