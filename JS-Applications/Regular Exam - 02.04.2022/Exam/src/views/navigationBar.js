import { html } from '../../node_modules/lit-html/lit-html.js';

const onlyGuestTemplate = html `
<!--Only Guest-->
<li><a href="/login">Login</a></li>
<li><a href="/register">Register</a></li>
`;

const onlyUserTemplate = html `
<!--Only Users-->
<li><a href="/create">Create Postcard</a></li>
<li><a href="/logout">Logout</a></li>
`;

const navigationBarTemplate = (user) => html `
<!--Navigation-->
<header>
    <nav>
        <section class="logo">
            <img src="./images/logo.png" alt="logo">
        </section>
        <ul>
            <!--Users and Guest-->
            <li><a href="/">Home</a></li>
            <li><a href="/dashboard">Dashboard</a></li>
            <!--Only Guest-->
            <!--Only Users-->
            ${user ? onlyUserTemplate : onlyGuestTemplate}
        </ul>
    </nav>
</header>
`;

export const navigationBarView = (context) => {
    return navigationBarTemplate(context.user);
}