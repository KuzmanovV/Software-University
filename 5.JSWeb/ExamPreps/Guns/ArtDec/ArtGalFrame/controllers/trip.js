const router = require('express').Router();

const { isUser, isOwner } = require('../midleware/guards');
const preload = require('../midleware/preload');
const { createTrip, updateTrip, deleteById, joinTrip } = require('../services/trip');
const mapErrors = require('../util/mappers');


router.get('/create', isUser(), (req, res) => {
    res.render('create', { title: 'Create art publication', data: {} });
});

router.post('/create', isUser(), async (req, res) => {
    const trip = {
        title: req.body.title,
        technique: req.body.technique,
        picture: req.body.picture,
        certificate: req.body.certificate,
        author: req.session.user._id,
        usersShared: req.body.usersShared,
    };

    try {
        await createTrip(trip);
        res.redirect('/catalog');
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        res.render('create', { title: 'Create publication', data: trip, errors });
    }
});

router.get('/edit/:id', preload(), isOwner(), async (req, res) => {
    res.render('edit', { title: 'Edit Publication' });
});

router.post('/edit/:id', preload(), isOwner(), async (req, res) => {
    const id = req.params.id;

    const trip = {
        title: req.body.title,
        technique: req.body.technique,
        picture: req.body.picture,
        certificate: req.body.certificate,
        author: req.body.author,
    };

    try {
        await updateTrip(id, trip);
        res.redirect('/trips/' + id);
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        trip._id = id;
        res.render('edit', { title: 'Create publication', trip, errors });
    }
});

router.get('/delete/:id', preload(), isOwner(), async (req, res) => {
    await deleteById(req.params.id);
    res.redirect('/catalog');
});

router.get('/join/:id', isUser(), async (req, res) => {
    const id = req.params.id;

    try {
        await joinTrip(id, req.session.user._id)
    } catch (err) {
        console.error(err);
    }finally{
        res.redirect('/');
    }
});

// router.get('/vote/:id/:type', isUser(), async(req, res) => {
//     const id = req.params.id;
//     const value = req.params.type == 'upvote' ? 1 : -1;

//     try {
//         await vote(id, req.session.user._id, value);
//         res.redirect('/catalog' + id);
//     } catch (err) {
//         console.error(err);
//         const errors = mapErrors(err);
//         res.render('/details/', { title: 'Post details', errors });
//     }
//});

module.exports = router;