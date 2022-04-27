const { Schema, model, Types: {ObjectId} } = require('mongoose');
const Accessory = require('./Accessory');
const User = require('./User');

const carSchema = new Schema({
    name: { type: String, required: true },
    description: { type: String, default: '' },
    imageUrl: { type: String, default: 'noImage.jps' },
    price: { type: Number, required: true, min: 0 },
    accessories: {type: [ObjectId], default: [], ref: Accessory},
    owner: {type: ObjectId, ref: 'User'}
});

const Car = model('Car', carSchema);

module.exports = Car;