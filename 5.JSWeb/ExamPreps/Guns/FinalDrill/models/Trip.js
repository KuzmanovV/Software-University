const {Schema, model, Types: {ObjectId}} = require('mongoose');

//TODO change the model name & fields according to exam descr and add validation
const URL_PATTERN = /^https?:\/\/(.+)/;

const tripSchema = new Schema({
    start: {type: String, required: true, minlength: [4, 'Starting Point should be at least 4 characters long']},
    end: {type: String, required: true, maxlength: [10, 'End Point should be at most 10 characters long']},
    certificate : {type: String, required: true, enum: ['Yes', 'No']},
    price: {type: Number, required: true, min: 1, max: 50},
    owner: {type: ObjectId, ref: 'User', required: true},
    buddies: {type: [ObjectId], ref: 'User', required: []},
    votes: {type: [ObjectId], ref: 'User', default: []},
    rating: {type: Number, default: 0},
    carImg: {type: String, required: true, validate: {
        validator(value){
            return URL_PATTERN.test(value);
        },
        message: 'Car image must be a valid URL.'
    }},
    date: {
        type: String,
        minlength: [10, 'Date must be 10 characters long.'],
        maxlength: [10, 'Date must be 10 characters long.']
    },
});

const Trip = model('Trip', tripSchema);

module.exports = Trip;