const express = require('express');
const expressConfig = require('./config/exrpess');
const databaseConfig = require('./config/database');
const routesConfig = require('./config/routes');

start();

async function start() {
    const app = express();

    expressConfig(app);
    await databaseConfig(app);
    routesConfig(app);  
    
    app.listen(3000, () => console.log('Server runnng on port 3000.'));
}