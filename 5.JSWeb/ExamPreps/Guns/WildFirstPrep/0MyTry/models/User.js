const { Schema, model, Types: { ObjectId } } = require('mongoose');

//TODO change the user model according to exam descr and add validation

const EMAIL_PATTERN = /^([a-zA-Z]+)@([a-zA-Z]+)\.([a-zA-Z]+)$/;
const NAME_PATTERN = /^[a-zA-Z-]+$/;

const userSchema = new Schema({
    firstName: {
        type: String, minlength: [3, 'First name must be at least 3 characters long.'], validate: {
            validator(value) {
                return NAME_PATTERN.test(value);
            },
            message: 'First name may contain only English letters.'
        }
    },
    lastName: {
        type: String, minlength: [5, 'Last name must be at least 5 characters long.'], validate: {
            validator(value) {
                return NAME_PATTERN.test(value);
            },
            message: 'Last name may contain only English letters.'
        }
    },
    email: {
        type: String, required: true, validate: {
            validator(value) {
                return EMAIL_PATTERN.test(value);
            },
            message: 'Email must be valid'
        }
    },
    hashedPassword: { type: String, required: true },
    // gender: { type: String, required: true, enum: ['male', 'female'] },
    // trips: { type: [ObjectId], ref: 'Trip', default: [] },
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