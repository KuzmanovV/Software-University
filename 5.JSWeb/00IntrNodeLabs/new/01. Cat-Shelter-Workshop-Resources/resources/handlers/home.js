const fs = require('fs');
const path = require('path');
//const cats = require('../data/cats');
//const breed = require('../data/breed');

module.exports = (req, res) => {
    const url = new URL(req.url, `http://${req.headers.host}`);
    const pathname = url.pathname;

    if (pathname === '/' && req.method === 'GET') {
        let filePath = path.join(__dirname, '../views/home/index.html');

        fs.readFile(filePath, (err, data) => {
            if (err) {
                console.log(err);
                res.writeHead(404, {
                    'Content-type': 'text/plain'
                });

                res.write('404 not found!');
                res.end();
                return;
            }

            res.writeHead(200, {
                'Content-type': 'text/html'
            });
            res.write(data);
            res.end();
        });

    } else {
        return true;
    }
}