import { register } from "../api/api.js";
import { html } from "../lib.js";
//import { notify } from '../notify.js';

const registerTemplate = (onSubmit) => html`
<section id="register">
            <div class="container">
                <form @submit=${onSubmit} id="register-form">
                    <h1>Register</h1>
                    <p>Please fill in this form to create an account.</p>
                    <hr>

                    <p>Username</p>
                    <input type="text" placeholder="Enter Username" name="username" required>

                    <p>Password</p>
                    <input type="password" placeholder="Enter Password" name="password" required>

                    <p>Repeat Password</p>
                    <input type="password" placeholder="Repeat Password" name="repeatPass" required>
                    <hr>

                    <input type="submit" class="registerbtn" value="Register">
                </form>
                <div class="signin">
                    <p>Already have an account?
                        <a href="/login">Sign in</a>.
                    </p>
                </div>
            </div>
        </section>`;

export function registerPage(ctx) {
    ctx.render(registerTemplate(onSubmit));

    async function onSubmit(event) {
        event.preventDefault();
        const formData = new FormData(event.target);

        const username = formData.get('username').trim();
        // const email = formData.get('email').trim();
        const password = formData.get('password').trim();
        const repeatPass = formData.get('repeatPass').trim();
        // const gender = formData.get('gender');

        if (username == '' || password == '') {
           // return notify('All fields are required!');
            return alert('All fields are required!');
        }
        if (password != repeatPass) {
           // return notify('Passwords don\'t match!');
            return alert('Passwords don\'t match!');
        }

        await register(username, password);
        ctx.updateUserNav();
        ctx.page.redirect('/catalog');
    }
}