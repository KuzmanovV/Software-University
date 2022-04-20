function lockedProfile() {
    let E = document.getElementById('main');
    E.addEventListener('click', e => {
        if (e.target.tagName == 'BUTTON') {
            let profile = e.target.parentElement;
            let isActive = profile.querySelector('input[type="radio"][value = "unlock"]').checked;

            if (isActive) {
                let hiddenE = profile.querySelector('div');

                if (e.target.textContent == 'Show more') {
                    hiddenE.style.display = 'block';
                    e.target.textContent = "Hide it";
                } else {
                    hiddenE.style.display = '';
                    e.target.textContent = 'Show more';
                }
            }
        }
    })
}