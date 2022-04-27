module.exports = {
    get(req, res){
        res.render('create', {title: 'Create listing'});
    },
    async post(req, res){
        const cub = {
            name: req.body.name,
            description: req.body.description,
            imageURL: req.body.imageURL,
            difficulty: Number(req.body.difficulty),
        };

        await req.storage.createCub(cub);
        
        res.redirect('/');
    }
}