const router = require('express').Router();
const { isUser } = require('../midleware/guards');


router.get('/create', isUser(), (req, res) =>{
    res.render('create', {title: 'Create Trip Offer'});
});

router.get('/create', isUser(), (req, res) =>{
    res.redirect('/trips');
});

module.exports = router;