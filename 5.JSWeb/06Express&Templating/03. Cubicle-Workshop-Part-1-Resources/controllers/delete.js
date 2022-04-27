module.exports = {
    async get(req, res){
        const id = req.params.id;
        const cub = await req.storage.getById(id);
        
        if (cub) {
            res.render('delete', {title: `Delete listing - ${cub.name}`, cub});
        } else{
            res.redirect('404');
        }
    },
    async post(req, res){
        const id = req.params.id;

        try {
            await req.storage.deleteById(id);
            res.redirect('/');
        } catch (err) {
            res.redirect('/404');
        }
    }
}