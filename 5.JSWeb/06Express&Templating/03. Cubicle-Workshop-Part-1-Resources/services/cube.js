const fs = require('fs/promises');

const filePath = './services/data.json';

async function read() {
    try {
        const file = await fs.readFile(filePath);
        return JSON.parse(file);
    } catch (err) {
        console.error('Database read error');
        console.error(err);
        process.exit(1);
    }
}

async function write(data) {
    try {
        await fs.writeFile(filePath, JSON.stringify(data, null, 2));
    } catch (err) {
        console.error('Database write error');
        console.error(err);
        process.exit(1);
    }
}

async function getAll(query) {
    const data = await read();
    let cubs = Object
        .entries(data)
        .map(([id, v]) => Object.assign({}, { id }, v));

    if (query.search) {
        cubs = cubs.filter(c=>c.name.toLocaleLowerCase().includes(query.search.toLocaleLowerCase()));
    }
    if (query.from) {
        cubs = cubs.filter(c=>c.difficulty>=Number(query.from));
    }
    if (query.to) {
        cubs = cubs.filter(c=>c.difficulty<=Number(query.to));
    }
    
    return cubs;
}

async function getById(id) {
    const data = await read();
    const cub = data[id];
    
    if(cub){
        return Object.assign({},{id},cub);
    }else{
        return undefined;
    }
}

async function deleteById(id) {
    const data = await read();
    
    if(data.hasOwnProperty(id)){
        delete data[id];
        await write(data);
    }else{
        throw new ReferenceError('No such ID in database');
    }
}

async function updateById(id, cub) {
    const data = await read();
    
    if(data.hasOwnProperty(id)){
        data[id] = cub;
        await write(data);
    }else{
        throw new ReferenceError('No such ID in database');
    }
}

async function createCub(cub) {
    const cubs = await read();

    let id;

    do{
        id=nextId()
    }while(cubs.hasOwnProperty(id));

    cubs[id] = cub;

    await write(cubs);
}

function nextId() {
    return 'xxxxxxxx-xxxx'.replace(/x/g, ()=>(Math.random() * 16|0).toString(16));
}

module.exports = () => (req, res, next) => {
    req.storage = {
        getAll,
        getById,
        createCub,
        deleteById,
        updateById,
    };
    next();
};