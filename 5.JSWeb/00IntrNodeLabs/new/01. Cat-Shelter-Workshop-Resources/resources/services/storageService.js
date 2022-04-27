const db = require('../db.json');
const fs = require('fs/promises');

const saveCat=(cat)=>{
    db.cats.push(cat);

    let result = JSON.stringify(db);
    fs.writeFile('../db.json', result);
}

const storageService = {
    saveCat,
}

module.exports = storageService;