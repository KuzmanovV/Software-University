const {Schema, model, Types: {ObjectId}} = require('mongoose');

const URL_PATTERN = /^https?:\/\/(.+)/;

const tripSchema = new Schema({
    title: {type: String, required: true, minlength: [6, 'Title should be at least 6 characters long']},
    technique: {type: String, required: true, maxlength: [15, 'Painting technique should be at most 15 characters long']},
    picture: {type: String, required: true, validate: {
        validator(value){
            return URL_PATTERN.test(value);
        },
        message: 'Art picture image must be a valid URL.'
    }},
    certificate : {type: String, required: true, enum: ['Yes', 'No']},
    author: {type: ObjectId, ref: 'User', required: true},
    usersShared: {type: [ObjectId], ref: 'User', required: []},
});

const Trip = model('Trip', tripSchema);

module.exports = Trip;