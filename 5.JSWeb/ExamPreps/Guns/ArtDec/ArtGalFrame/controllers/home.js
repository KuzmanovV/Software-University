const { isUser } = require('../midleware/guards');
const preload = require('../midleware/preload');
const { getAllTrips, getTripsByUser, getUserById } = require('../services/trip');

const router = require('express').Router();


router.get('/', (req, res) => {
    res.render('home');
});

router.get('/catalog', async (req, res) => {
    const trips = await getAllTrips();
    res.render('catalog', { title: 'Shared trips', trips });
});

router.get('/trips/:id', preload(true), async (req, res) => {
    const trip = res.locals.trip;
    //trip.remainingSeats = trip.seats - trip.buddies.length;
    trip.sharedList = trip.usersShared.map(b => b.title).join(', ');
    if (req.session.user) {
        trip.hasUser = true;
        trip.isOwner = req.session.user._id == trip.author._id;
        if (trip.usersShared.some(b=>b._id == req.session.user._id)) {
            trip.isJoined = true;
        }
    }
    res.render('details', { title: 'Trip details' });
});

router.get('/profile', isUser(), async (req, res) =>{
    //const tripsByUser = await getTripsByUser(res.locals.user._id);
    //res.locals.user.tripCount = tripsByUser.length;
    //res.locals.user.trips = tripsByUser;
    res.render('profile', {title: 'Profile Page'});
});

// My POSTS
// router.get('/myPosts', isUser(), async (req, res) =>{
//     const posts = await getPostsByAuthor(req.session.user._id);
//     res.render('myPosts', {title: 'Own Posts Page', posts});
// });

module.exports = router;
