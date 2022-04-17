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

const routes = {
    '#home': homeTemplate,
    '#articles': articlesTemplate,
    '#about': aboutTemplate,
};

const root = document.getElementById('root');

window.addEventListener('hashchange', (ev) => {
    // console.log('Changed');
    // console.log(location.hash);
    let template = routes[location.hash];

    root.innerHTML = template();
});
//cd .\hash-router\
//npm init --yes
//npm i lite-server
//npm start