const http = require('http');
const homePage = require('./views/home/home');
const siteCSS = require('./content/styles/site');
const addCatPage = require('./views/addCat');
const cats = require('./data/cats.json');
const addBreedPage = require('./views/addBreed');

const breeds = require('./data/breeds.json');

const catsTemplate = (cat) => `  
<li>
    <img src="${cat.imageUrl}" alt="Black Cat">
    <h3>${cat.name}</h3>
    <p><span>Breed: </span>${cat.breed}</p>
    <p><span>Description: </span>${cat.description}</p>
    <ul class="buttons">
        <li class="btn edit"><a href="">Change Info</a></li>
        <li class="btn delete"><a href="">New Home</a></li>
    </ul>
</li>
`;

const server = http.createServer((req, res) => {
    res.writeHead(200, {
        'Content-Type': 'text/html'
    });

    if (req.url == '/content/styles/site.css') {

        res.writeHead(200, {
            'Content-Type': 'text/css'
        });

        res.write(siteCSS);
    } else if (req.url == '/cats/add-cat') {
        res.write(addCatPage);
    } else if (req.url == '/cats/add-breed') {
        res.write(addBreedPage);
    } else {
        const homePageResult = homePage.replace('{{cats}}', cats.map(x => catsTemplate(x)).join(''));

        res.write(homePageResult);
    }

    res.end();
});

server.listen(5000, () => console.log('Server is listening on port 5000...'));