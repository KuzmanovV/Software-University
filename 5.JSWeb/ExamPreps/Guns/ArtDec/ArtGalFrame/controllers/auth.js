const router = require('express').Router();
const { isUser, isGuest } = require('../midleware/guards');
const { register, login } = require('../services/user');
const mapErrors = require('../util/mappers');

router.get('/register', isGuest(), (req, res) => {
    res.render('register');
});

router.post('/register', isGuest(), async (req, res) => {
    try {
        if (req.body.password.trim().length<3) { 
            throw new Error('Passords must be at least 3 characters long.');
        }
        if (req.body.password != req.body.repass) {
            throw new Error('Passords don\'t match!');
        }

        const user = await register(req.body.username, req.body.password, req.body.address);
        req.session.user = user;
        res.redirect('/');    
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        //const isMale = req.body.gender == 'male';   // if needed
        res.render('register', { data: { username: req.body.username, address: req.body.address}, errors });  // isMale - if needed
    }
});

router.get('/login', isGuest(), (req, res) => {
    res.render('login');
});

router.post('/login', isGuest(), async (req, res) => {
    try {
        const user = await login(req.body.username, req.body.password);
        req.session.user = user;
        res.redirect('/');
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        res.render('login', { data: { username: req.body.username }, errors });
    }
});

router.get('/logout', isUser(), (req, res)=>{
    delete req.session.user;
    res.redirect('/');
});

module.exports = router;