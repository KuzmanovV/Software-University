const homeController = require('../controllers/home');
const authController = require('../controllers/auth');
const postController = require('../controllers/post');

module.exports = (app) => {
    app.use(homeController);
    app.use(authController);
    app.use(postController);
};