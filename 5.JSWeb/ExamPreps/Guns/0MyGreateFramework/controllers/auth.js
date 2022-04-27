const router = require('express').Router();
const { isUser, isGuest } = require('../midleware/guards');
const { register, login } = require('../services/user');
const mapErrors = require('../util/mappers');

router.get('/register', isGuest(), (req, res) => {
    res.render('register');
});

//TODO Check form action, method, field names.
router.post('/register', isGuest(), async (req, res) => {
    try {
        if (req.body.password.trim().length<4) {     //Check requirements about password length
            throw new Error('Passords must be at least 4 characters long.');
        }
        if (req.body.password != req.body.repass) {
            throw new Error('Passords don\'t match!');
        }

        const user = await register(req.body.email, req.body.password, req.body.gender);
        req.session.user = user;
        res.redirect('/');          //TODO Check redirect requirements.
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        const isMale = req.body.gender == 'male';   // if needed
        res.render('register', { data: { email: req.body.email, isMale }, errors });        // isMale - if needed
    }
});

router.get('/login', isGuest(), (req, res) => {
    res.render('login');
});

//TODO Check form action, method, field names.
router.post('/login', isGuest(), async (req, res) => {
    try {
        const user = await login(req.body.email, req.body.password);
        req.session.user = user;
        res.redirect('/');      //TODO Check redirect requirements.
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        res.render('login', { data: { email: req.body.email }, errors });
    }
});

router.get('/logout', isUser(), (req, res)=>{
    delete req.session.user;
    res.redirect('/');
});

module.exports = router;