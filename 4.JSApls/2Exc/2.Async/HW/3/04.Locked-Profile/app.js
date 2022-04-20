async function lockedProfile() {
    let mainId = document.querySelector('#main');

    let url = 'http://localhost:3030/jsonstore/advanced/profiles';
    let response = await fetch(url);

    if (response.ok == false) {
        throw new Error('');
    }

    let data = await response.json();

    Object.keys(data).forEach((user, i) => {
        let { _id, username, email, age } = data[user];
        let index = i + 1;

        let userToCreate = `
            <div class="profile">
				<img src="./iconProfile2.png" class="userIcon" />
				<label>Lock</label>
				<input type="radio" name='user${index}Locked' value="lock" checked>
				<label>Unlock</label>
				<input type="radio" name='user${index}Locked' value="unlock"><br>
				<hr>
				<label>Username</label>
				<input type="text" name='user${index}Username' value='${username}' disabled readonly />
				<div class="hiddenInfo">
					<hr>
					<label>Email:</label>
					<input type="email" name='user${index}Email' value='${email}' disabled readonly />
					<label>Age:</label>
					<input type="email" name='user${index}Age' value='${age}' disabled readonly />
				</div>
				
				<button style="background-color: #8da5bd;" disabled>Show more</button>
			</div>`;

        mainId.insertAdjacentHTML('beforeend', userToCreate);
    });

    document.addEventListener('click', onClick);

    function onClick(event) {
        let parent = event.target.parentElement;
        let showMoreBtn = parent.querySelector('.profile button');
        let radioValue = event.target.value;

        if (event.target.localName == 'input' && event.target.type == 'radio') {
            if (radioValue == 'lock') {
                showMoreBtn.style.backgroundColor = '#8da5bd';
                showMoreBtn.disabled = true;
            }

            if (radioValue == 'unlock') {
                showMoreBtn.style.backgroundColor = '#234465';
                showMoreBtn.disabled = false;
            }
        }

        if (event.target.localName == 'button') {
            let isHidden = showMoreBtn.textContent == 'Show more' ? true : false;
            let hiddenInfo = Array.from(parent.querySelector('.hiddenInfo').children);

            if (event.target.textContent.includes('Show') && isHidden) {
                showMoreBtn.textContent = 'Hide it';
                hiddenInfo.forEach(x => x.style.display = 'block');
            } else {
                showMoreBtn.textContent = 'Show more';
                hiddenInfo.forEach(x => x.style.display = 'none');
                hiddenInfo[0].style.display = 'block';
            }
        }
    }
}