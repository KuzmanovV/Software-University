const authController = require('../controllers/auth');
const homeController = require('../controllers/home');
const genController = require('../controllers/gen');

module.exports = (app) => {
    app.use(authController);
    app.use(genController);
    app.use(homeController);

    app.get('*', (req, res) => {
        res.render('404', { title: 'Page Not Found' });
    });
};