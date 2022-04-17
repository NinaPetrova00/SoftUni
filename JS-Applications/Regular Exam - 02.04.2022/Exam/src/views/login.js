import { html } from '../../node_modules/lit-html/lit-html.js';
import * as userService from '../services/userService.js'

const loginTemplate = (onSubmit) => html `   
<!--Login Page-->
<section id="loginPage">
    <form @submit=${onSubmit} class="loginForm">
        <img src="./images/logo.png" alt="logo" />
        <h2>Login</h2>

        <div>
            <label for="email">Email:</label>
            <input id="email" name="email" type="text" placeholder="steven@abv.bg" value="">
        </div>

        <div>
            <label for="password">Password:</label>
            <input id="password" name="password" type="password" placeholder="********" value="">
        </div>

        <button class="btn" type="submit">Login</button>

        <p class="field">
            <span>If you don't have profile click <a href="/register">here</a></span>
        </p>
    </form>
</section>
`;

export const loginView = (context) => {

    const onSubmit = (ev) => {
        ev.preventDefault();

        const { email, password } = Object.fromEntries(new FormData(ev.currentTarget));

        if (email == '' || password == '') {
            alert('All fields should be filled');
            return;
        }

        userService.login(email, password)
            .then(() => {
                context.page.redirect('/');
            })
            .catch(err => {
                alert(err);
            });
    };
    context.render(loginTemplate(onSubmit));
}