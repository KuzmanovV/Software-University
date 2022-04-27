const exrpess = require('express');
const hbs = require('express-handlebars');

const initDb = require('./models/index');

const cubServices = require('./services/cube');

const { about } = require('./controllers/about');
const create = require('./controllers/create');
const { details } = require('./controllers/details');
const { home } = require('./controllers/home');
const deleteCub = require('./controllers/delete');
const { notFound } = require('./controllers/notFound');
const edit = require('./controllers/edit');
const init = require('./models/index');

start();

async function start() {
    await initDb();

    const app = exrpess();

    app.engine('hbs', hbs.create({
        extname: '.hbs'
    }).engine);
    app.set('view engine', '.hbs');

    app.use(exrpess.urlencoded({ extended: true }));
    app.use('/static', exrpess.static('static'));
    app.use(cubServices());

    app.get('/', home);
    app.get('/about', about);
    app.get('/details/:id', details);

    app.route('/create')
        .get(create.get)
        .post(create.post);

    app.route('/delete/:id')
        .get(deleteCub.get)
        .post(deleteCub.post);

    app.route('/edit/:id')
        .get(edit.get)
        .post(edit.post);

    app.all('*', notFound);

    app.listen(3000, () => console.log('Server started on port 3000...'));
};