const { Schema, model, Types: { ObjectId } } = require('mongoose');


//const EMAIL_PATTERN = /^([a-zA-Z]+)@([a-zA-Z]+)\.([a-zA-Z]+)$/;
//const NAME_PATTERN = /^[a-zA-Z-]+$/;

const userSchema = new Schema({
    username: {type: String, required: true, minlength: [4, 'Username should be at least 4 characters long']},
    hashedPassword: { type: String, required: true },
    address: {type: String, required: true, maxlength: [20, 'Address should be at most 20 characters long']},
    publications: {type: [ObjectId], ref: 'Trip', required: []},
});

// userSchema.index({ email: 1 }, {
//     unique: true,
//     collation: {
//         locale: 'en',
//         strength: 2
//     }
// });

const User = model('User', userSchema);

module.exports = User;