const { isUser } = require('../midleware/guards');
const preload = require('../midleware/preload');
const { getAllGens, getGensByUser, getPostsByAuthor } = require('../services/gen');

const router = require('express').Router();


router.get('/', (req, res) => {
    res.render('home');
});

router.get('/catalog', async (req, res) => {
    const gens = await getAllGens();
    res.render('catalog', { title: 'All posts', gens });
});

//DETAILS
router.get('/gens/:id', preload(true), (req, res) => {
    const gen = res.locals.gen;
    //trip.remainingSeats = trip.seats - trip.buddies.length;
    //gen.buddiesList = gen.buddies.map(b => b.email).join(', ');
    if (req.session.user) {
        gen.hasUser = true;
        gen.isOwner  = req.session.user._id == gen.owner._id;

        // gen.isJoined = true;
        // if (gen.buddies.some(b=>b._id == req.session.user._id)) {
        //     gen.isJoined = false;
        // }
    }
    res.render('details', { title: 'Post details' });
});

// My POSTS
router.get('/myPosts', isUser(), async (req, res) =>{
    const posts = await getPostsByAuthor(req.session.user._id);
    res.render('myPosts', {title: 'Own Posts Page', posts});
});

module.exports = router;
