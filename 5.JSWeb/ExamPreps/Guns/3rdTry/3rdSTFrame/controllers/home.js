const router = require('express').Router();
const preload = require('../midleware/preload');
const { getAllTrips } = require('../services/trip');


router.get('/', (req, res) =>{
    res.render('home');
});

router.get('/trips', async (req, res) =>{
    const trips = await getAllTrips();
    res.render('catalog', {title: 'Shared Trips', trips });
});

router.get('/trips/:id', preload(true), (req, res) =>{
    //TODO for the details buttons
    if (req.session.user) {
        res.locals.trip.hasUser = true;
        res.locals.trip.isOwner = req.session.user._id == res.locals.trip.owner._id;
    }
    
    res.render('details', {title: 'Trip Details' });
});

module.exports = router;