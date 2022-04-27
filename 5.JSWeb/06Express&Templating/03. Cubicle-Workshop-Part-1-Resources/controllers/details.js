module.exports = {
    async details(req, res){
        const id = req.params.id;
        const cub = await req.storage.getById(id);

        if (cub) {
            res.render('details', {title: `Cubicle - ${cub.name}`, cub});
        }else{
            res.redirect('/404');
        }
    }
}