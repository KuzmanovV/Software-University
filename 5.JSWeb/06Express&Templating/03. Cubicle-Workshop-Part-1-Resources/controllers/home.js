module.exports = {
    async home(req, res){
        const cubs = await req.storage.getAll(req.query);

        res.render('index', {cubs, title: 'Cubicle', query: req.query});
    }
};