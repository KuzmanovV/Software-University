const { Schema, model, Types: { ObjectId } } = require('mongoose');


const EMAIL_PATTERN = /^([a-zA-Z]+)@([a-zA-Z]+)\.([a-zA-Z]+)$/;
//const NAME_PATTERN = /^[a-zA-Z-]+$/;

const userSchema = new Schema({
    // username: {type: String, required: true, minlength: [4, 'Username should be at least 4 characters long']},
    email: {
        type: String, required: true, validate: {
            validator(value) {
                return EMAIL_PATTERN.test(value);
            },
            message: 'Email must be valid'
        }
    },
    hashedPassword: { type: String, required: true },
    description: { type: String, required: true, maxlength: [40, 'Description should be at most 40 characters long'] },
    myAds: { type: [ObjectId], ref: 'Trip', default: [] },

    //     gender: { type: String, required: true, enum: ['male', 'female'] },
    //     firstName: {
    //         type: String, minlength: [3, 'First name must be at least 3 characters long.'], validate: {
    //             validator(value) {
    //                 return NAME_PATTERN.test(value);
    //             },
    //             message: 'First name may contain only English letters.'
    //         }
    //     },
});

userSchema.index({ email: 1 }, {
    unique: true,
    collation: {
        locale: 'en',
        strength: 2
    }
});

const User = model('User', userSchema);

module.exports = User;