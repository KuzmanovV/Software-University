function lockedProfile() {
    getUsers()
}
async function getUsers() {
    const url = 'http://localhost:3030/jsonstore/advanced/profiles';

    const res = await fetch(url);
    const data = await res.json();
    let divToAdd = document.getElementById('container')
    
    Object.entries(data).forEach((p, i) => {
        let mainToAd = document.createElement('main')
        mainToAd.id = 'main';
        mainToAd.innerHTML = `
        <div class="profile">
            <img src="./iconProfile2.png" class="userIcon" />
            <label>Lock</label>
            <input type="radio" name="user${i+1}Locked" value="lock" checked>
            <label>Unlock</label>
            <input type="radio" name="user${i+1}Locked" value="unlock"><br>
            <hr>
            <label>Username</label>
            <input type="text" name="user${i+1}Username" value="${p[1].username}" disabled readonly />
            <div id="user${i+1}HiddenFields">
                <hr>
                <label>Email:</label>
                <input type="email" name="user${i+1}Email" value="${p[1].email}" disabled readonly />
                <label>Age:</label>
                <input type="email" name="user${i+1}Age" value="${p[1].age}" disabled readonly />
            </div>
            <button>Show more</button>
        </div>`
        divToAdd.appendChild(mainToAd)
    });
    let profiles = document.querySelectorAll('.profile');
    let buttons = Array.from(document.querySelectorAll('button'));
    
    console.log(buttons.length);
    for(let i = 0; i < buttons.length; i++) {
        buttons[i].addEventListener('click', () => {
            let radioNameBtn = `user${i + 1}Locked`
            let radioBtn = document.querySelector(`input[name="${radioNameBtn}"]:checked`)
            if(radioBtn.value === 'unlock') {
                let hiddenField = document.getElementById(`user${i + 1}HiddenFields`)
                hiddenField.style.display = hiddenField.style.display === 'block' ? 'none' : 'block'
                buttons[i].textContent = buttons[i].textContent === 'Show more' ? 'Hide it' : 'Show more'
            }
        });
    }
}