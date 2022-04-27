const {Schema, model, Types: {ObjectId}} = require('mongoose');

const URL_PATTERN = /^https?:\/\/(.+)/;

const genSchema = new Schema({
    title: {type: String, required: true, minlength: [6, 'Title should be at least 6 characters long']},
    keyword: {type: String, required: true, minlength: [6, 'Keyword should be at least 6 characters long']},
    location: {type: String, required: true, maxlength: [15, 'Location should be at most 15 characters long']},
    date: {
        type: String,
        minlength: [10, 'Date must be 10 characters long.'],
        maxlength: [10, 'Date must be 10 characters long.']
    },
    image: {type: String, required: true, validate: {
        validator(value){
            return URL_PATTERN.test(value);
        },
        message: 'Image must be a valid URL.'
    }},
    description: {type: String, required: true, minlength: [8, 'Description should be at least 8 characters long']},
    owner: {type: ObjectId, ref: 'User', required: true},
    votes: {type: [ObjectId], ref: 'User', default: []},
    rating: {type: Number, default: 0},
    buddies: {type: [ObjectId], ref: 'User', required: []},
});

const Gen = model('Gen', genSchema);

module.exports = Gen;