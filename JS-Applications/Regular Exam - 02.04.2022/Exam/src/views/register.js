import { html } from '../../node_modules/lit-html/lit-html.js';
import * as userService from '../services/userService.js';

const registerTemplate = (onSubmit) => html `
<!--Register Page-->
<section id="registerPage">
    <form @submit=${onSubmit} class="registerForm">
        <img src="./images/logo.png" alt="logo" />
        <h2>Register</h2>
        <div class="on-dark">
            <label for="email">Email:</label>
            <input id="email" name="email" type="text" placeholder="steven@abv.bg" value="">
        </div>

        <div class="on-dark">
            <label for="password">Password:</label>
            <input id="password" name="password" type="password" placeholder="********" value="">
        </div>

        <div class="on-dark">
            <label for="repeatPassword">Repeat Password:</label>
            <input id="repeatPassword" name="repeatPassword" type="password" placeholder="********" value="">
        </div>

        <button class="btn" type="submit">Register</button>

        <p class="field">
            <span>If you have profile click <a href="/login">here</a></span>
        </p>
    </form>
</section>
`;

export const registerView = (context) => {

    const onSubmit = (ev) => {
        ev.preventDefault();

        const { email, password, repeatPassword } = Object.fromEntries(new FormData(ev.currentTarget));

        if (password !== repeatPassword) {
            alert('Passwords don\'t match');
            return;
        }

        if (email == '' || password == '' || repeatPassword == '') {
            alert('All fields should be filled');
            return;
        }

        userService.register(email, password)
            .then(() => {
                context.page.redirect('/');
            })
            .catch(err => {
                alert(err);
            });
    };
    context.render(registerTemplate(onSubmit));

}