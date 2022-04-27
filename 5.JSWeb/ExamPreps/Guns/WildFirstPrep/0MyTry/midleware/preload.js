//TODO repalce with actual service.
const genService = require('../services/gen');


function preload(populate) {
    return async function (req, res, next) {
        const id = req.params.id;
        if (populate) {
            res.locals.gen = await genService.getGenAndUsers(id);
        } else {
            res.locals.gen = await genService.getGenById(id);
        }

        next();
    };
};

module.exports = preload;