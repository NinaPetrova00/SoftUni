import { render, html } from '../../node_modules/lit-html/lit-html.js';

const navTemplate = (user) => html `
<!-- Navigation -->
<h1><a class="home" href="#">GamesPlay</a></h1>
<nav>
    <a href="/catalog">All games</a>

    ${user
        ? html`
    <!-- Logged-in users -->
    <div id="user">
        <a href="/create">Create Game</a>
        <a href="/logout">Logout</a>
    </div>`
    : html`
    <!-- Guest users -->
    <div id="guest">
        <a href="/login">Login</a>
        <a href="/register">Register</a>
    </div>`}

</nav>
`;

const header = document.querySelector('.my-header');
const root = document.getElementById('main-content');

function contextRender(content) {
    render(content, root);
}

export function addRender(context, next) {

    render(navTemplate(context.user),header);

    context.render = contextRender;

    next();
}