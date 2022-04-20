window.addEventListener('load', () => {
    document.getElementById('user').style.display = 'none';
    const form = document.querySelector('#login-view form');
    form.addEventListener('submit', userLogin);
})

async function userLogin(event) {
    event.preventDefault();

    const formData = new FormData(event.target);

    const email = formData.get('email').trim();
    const password = formData.get('password').trim();
    try {
        if (email === '' || password === '') {
            throw new Error('Please fill all fields.')
        }
        const res = await fetch('http://localhost:3030/users/login', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ email, password })
        })

        if (res.ok === false) {
            const err = await res.json();
            throw new Error(err.message)
        }

        event.target.reset();
        const data = await res.json();
        const userData =  {
            email: data.email,
            id: data._id,
            token: data.accessToken
        }
        localStorage.setItem('userData', JSON.stringify(userData));
        window.location = './index.html';
    } catch (error) {
        alert(error.message)
    }

}