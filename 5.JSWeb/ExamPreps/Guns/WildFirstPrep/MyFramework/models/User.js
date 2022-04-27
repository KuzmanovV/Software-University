const {Schema, model, Types: {ObjectId}} = require('mongoose');

//TODO change the user model according to exam descr.
//TODO add validation.

const userSchema = new Schema({
    username: {type: String, required: true},
    hashedPassword: { type: String, required: true},
    //trips: { type: [ObjectId], ref: 'Trip', default: []},
});

userSchema.index({username: 1}, {
    unique: true,
    collation: {
        locale: 'en',
        strength: 2
    }
});

const User = model('User', userSchema);

module.exports = User;