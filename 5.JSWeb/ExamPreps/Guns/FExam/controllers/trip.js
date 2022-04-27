const router = require('express').Router();

const { isUser, isOwner } = require('../midleware/guards');
const preload = require('../midleware/preload');
const { createTrip, updateTrip, deleteById, joinTrip } = require('../services/trip');
const mapErrors = require('../util/mappers');


router.get('/create', isUser(), (req, res) => {
    res.render('create', { title: 'Create Ad', data: {} });
});

router.post('/create', isUser(), async (req, res) => {
    const trip = {
        headline: req.body.headline,
        location: req.body.location,
        name: req.body.name,
        description: req.body.description,
        author: req.session.user._id,
        usersApplied: req.body.usersApplied,
    };

    try {
        await createTrip(trip);
        res.redirect('/catalog');
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        res.render('create', { title: 'Create Ad', data: trip, errors });
    }
});

router.get('/edit/:id', preload(), isOwner(), async (req, res) => {
    res.render('edit', { title: 'Edit Ad' });
});

router.post('/edit/:id', preload(), isOwner(), async (req, res) => {
    const id = req.params.id;

    const trip = {
        headline: req.body.headline,
        location: req.body.location,
        name: req.body.name,
        description: req.body.description,
        author: req.session.user._id,
        //usersApplied: req.body.usersApplied,
    };

    try {
        await updateTrip(id, trip);
        res.redirect('/trips/' + id);
    } catch (err) {
        console.error(err);
        const errors = mapErrors(err);
        trip._id = id;
        res.render('edit', { title: 'Update Ad', trip, errors });
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
        res.redirect('/trips/' + id);
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