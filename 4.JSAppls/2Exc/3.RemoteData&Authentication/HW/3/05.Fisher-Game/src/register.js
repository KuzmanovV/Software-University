window.addEventListener('load', () => {
    const form = document.querySelector('#register-view form');
    document.getElementById('user').style.display = 'none';
    form.addEventListener('submit', userRegister);
})

async function userRegister(event) {
    event.preventDefault();

    const formData = new FormData(event.target);

    const email = formData.get('email').trim();
    const password = formData.get('password').trim();
    const rePass = formData.get('rePass').trim();

    try {
        // console.log(event.target);
        if (email === '' || password === '' || rePass === '') {
            throw new Error('All fields must be filled');
        }

        if (password !== rePass) {
            throw new Error(`Passwords don't match`);
        }
        
        const res = await fetch('http://localhost:3030/users/register', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ email, password })
        });
        if (res.ok === false) {
            const err = await res.json();
            throw new Error(err.message);
        }
        const data = await res.json();
        const userData = {
            email: data.email,
            id: data._id,
            token: data.accessToken
        }
        localStorage.setItem('userData', JSON.stringify(userData));
        // console.log(data);
        window.location = '/index.html'
    } catch (error) {
        alert(error.message)
    }

}