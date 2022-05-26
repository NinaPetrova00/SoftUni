const express = require('express');
const fs = require('fs');
const path = require('path');
const handlebars = require('express-handlebars');

const { catMiddleware } = require('./middlewares');

const users = [
    { name: 'Nina', age: 22 },
    { name: 'Teodor', age: 17 },
    { name: 'Alex', age: 25 },
];

const app = express();

app.engine('hbs', handlebars.engine({
    extname: 'hbs'
}));

app.set('view engine', 'hbs');

app.use(catMiddleware);

app.use('/static', express.static('public'));

app.get('/:name?', (req, res) => {
    // res.write('Hello world!');
    // res.end();
    //res.send('Hello World!');

    res.render('home', {
        name: req.params.name || 'Guest',
        users: users,
        isAuth: true,
        danger: '<script>alert("you are hacked!")</script>'
    });
});

app.get('/images/:imgName', (req, res) => {
    res.sendFile(path.resolve('./public/images', req.params.imgName));
});

// app.get('/cats', (req, res) => {
//     if (cats.length > 0) {
//         res.send(cats.join(', '));
//     } else {
//         res.send('No cats here!');
//     }
// });

app.get('/cats', (req, res) => {
    if (req.cats.length > 0) {
        res.send(req.cats.join(', '));
    } else {
        res.send('No cats here!');
    }
});

app.get('/cats/:catId(\\d+)', (req, res) => {
    let catId = Number(req.params.catId);

    res.send(cats[catId]);
});

// app.get('/cats/:catName', (req, res) => {
// // TODO:...
//     res.send
// });

app.post('/cats/:catName', (req, res) => {

    req.cats.push(req.params.catName);

    res.status(201);
    res.send(`Added cat ${req.params.catName} to the collection`);
});

app.put('/cats', (req, res) => {
    res.send('Modify existing cat');
});


// *1) way:  Default way 
app.get('/download', (req, res) => {
    res.writeHead(200, {
        'content-disposition': 'attachment; fileName="sample.pdf"'
            //'content-disposition': 'inline'
    });

    const readStream = fs.createReadStream('sample.pdf');

    // readStream.on('data', (data) => {
    //     res.write(data);
    // });

    // readStream.on('end', () => {
    //     res.end();
    // });
    readStream.pipe(res);
});

// *2) way: Express way
app.get('/express-download', (req, res) => {
    res.download('sample.pdf'); // терминира заявката автоматично
    //res.attachment('sample.pdf');
});


// **1) way: http module
app.get('/redirect', (req, res) => {
    res.writeHead(302, {
        'Location': '/cats'
    });

    res.end();
});

// **2) way: express
app.get('/express-redirect', (req, res) => {
    res.redirect('/cats');
});


app.get('/cat*', (req, res) => {
    res.send('Router starting with cat');
});

app.all('*', (req, res) => {
    res.status(404);
    res.send('Cannot find this page');
});

app.listen(5000, () => console.log('Server is listening on port 5000...'));