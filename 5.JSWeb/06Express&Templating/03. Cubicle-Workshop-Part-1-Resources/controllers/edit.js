module.exports = {
    async get(req, res){
        const id = req.params.id;
        const cub = await req.storage.getById(id);
        
        if (cub) {
            res.render('edit', {title: `Edit listing - ${cub.name}`, cub});
        } else{
            res.redirect('404');
        }
    },
    async post(req, res){
        const id = req.params.id;
        const cub = {
            name: req.body.name,
            description: req.body.description,
            imageUrl: req.body.imageUrl,
            difficulty: Number(req.body.difficulty),
        }

        try {
            await req.storage.updateById(id, cub);
            res.redirect('/');
        } catch (err) {
            res.redirect('/404');
        }
    }
}