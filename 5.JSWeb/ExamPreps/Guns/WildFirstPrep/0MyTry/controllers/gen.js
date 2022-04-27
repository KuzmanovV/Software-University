const router = require('express').Router();

const { isUser, isOwner } = require('../midleware/guards');
const preload = require('../midleware/preload');
const { createGen, updateGen, deleteById, joinTrip, vote } = require('../services/gen');
const mapErrors = require('../util/mappers');


router.get('/create', isUser(), (req, res) => {
    res.render('create', { title: 'Create post', data: {} });
});

router.post('/create', isUser(), async (req, res) => {
    const gen = {
        title: req.body.title,
        keyword: req.body.keyword,
        location: req.body.location,
        date: req.body.date,
        image: req.body.image,
        description: req.body.description,
        owner: req.session.user._id,
    };

    try {
        await createGen(gen);
        res.redirect('/catalog');
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        res.render('create', { title: 'Create post', data: gen, errors });
    }
});

router.get('/edit/:id', preload(), isOwner(), async (req, res) => {
    res.render('edit', { title: 'Edit Offer' });
});

router.post('/edit/:id', preload(), isOwner(), async (req, res) => {
    const id = req.params.id;

    const gen = {
        title: req.body.title,
        keyword: req.body.keyword,
        location: req.body.location,
        date: req.body.date,
        image: req.body.image,
        description: req.body.description,
    };

    try {
        await updateGen(id, gen);
        res.redirect('/gens/' + id);
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        trip._id = id;
        res.render('edit', { title: 'Create post', gen, errors });
    }
});

router.get('/delete/:id', preload(), isOwner(), async (req, res) => {
    await deleteById(req.params.id);
    res.redirect('/catalog');
});

router.get('/vote/:id/:type', isUser(), async(req, res) => {
    const id = req.params.id;
    const value = req.params.type == 'upvote' ? 1 : -1;

    try {
        await vote(id, req.session.user._id, value);
        res.redirect('/catalog' + id);
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        res.render('/details/', { title: 'Post details', errors });
    }
});

module.exports = router;