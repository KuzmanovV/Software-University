const http = require('http');
const fs = require('fs');
const formidable = require('formidable');
const storageService = require('./services/storageService.js');
const port = 3000;
// const handlers = require('./handlers');

http.createServer((req, res) => {
    if (req.url === '/' && req.method === 'GET') {
        res.writeHead(200, {
            'Content-type': 'text/html'
        });
        res.write(fs.readFileSync('./views/home/index.html'));
        res.end();

    } else if (req.url === '/content/styles/site.css') {
        res.writeHead(200, {
            'Content-type': 'text/css'
        });
        res.write(fs.readFileSync('./content/styles/site.css'));
        res.end();
    } else if (req.url === '/cats/add-cat') {
        if (req.method === 'GET') {
            res.writeHead(200, {
                'Content-type': 'text/html'
            });
            fs.readFile('./views/addCat.html', (err, result) => {
                if (err) {
                    res.statusCode = 404;
                    return res.end();
                }
                res.write(result);
                res.end();
            });
        } else if (req.method === 'POST') {
            let form = new formidable.IncomingForm();
            form.parse(req, (err, fields, files)=>{
                storageService.saveCat(fields);
                res.end();
            })
        }
    } else {
        res.writeHead(404, {
            'Content-type': 'text/plain'
        });

        res.write('404 not found!');
        res.end();
    }
}).listen(port, () => console.log(`Server is listening on port ${port}...`));