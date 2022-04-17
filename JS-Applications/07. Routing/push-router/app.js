const homeTemplate = () => `
    <h1>Home</h1>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, molestias!</p>
`;

const articlesTemplate = () => `
    <h1>Articles</h1>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, molestias!</p>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, molestias!</p>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, molestias!</p>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, molestias!</p>
`;

const aboutTemplate = () => `
    <h1>About</h1>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, molestias!</p>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, molestias!</p>
`;

const notFoundTemplate = () => `
<h1> Page not found </h1>
`;

const routes = {
    '/home': homeTemplate,
    '/articles': articlesTemplate,
    '/about': aboutTemplate,
};

const root = document.getElementById('root');

const navigate = (pathname, pushState = true) => {

    if (pushState) {
        history.pushState({}, '', pathname);
    }

    let template = routes[pathname];

    if (!template) {
        template = notFoundTemplate;
    }

    root.innerHTML = template();
};

document.body.addEventListener('click', (ev) => {
    if (ev.target.tagName == 'A') {
        ev.preventDefault();
        let url = new URL(ev.target.href);
        navigate(url.pathname);
    }
});

window.addEventListener('popstate', (ev) => {
    navigate(location.pathname, false);
});

navigate(location.pathname, false);