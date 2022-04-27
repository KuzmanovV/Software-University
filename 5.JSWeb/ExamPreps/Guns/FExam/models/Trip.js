const { Schema, model, Types: { ObjectId } } = require('mongoose');


const tripSchema = new Schema({
    headline: { type: String, required: true, minlength: [4, 'Headline should be at least 4 characters long'] },
    location: { type: String, required: true, minlength: [8, 'Location should be at least 8 characters long'] },
    name: { type: String, required: true, minlength: [3, 'Company name should be at least 3 characters long'] },
    description: { type: String, required: true, maxlength: [40, 'Company description should be at most 40 characters long'] },
    author: { type: ObjectId, ref: 'User', required: true },
    usersApplied: { type: [ObjectId], ref: 'User', required: [] },
});

const Trip = model('Trip', tripSchema);

module.exports = Trip;