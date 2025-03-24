const mongoose = require('mongoose');
const userSchema = mongoose.Schema;

const User = new userSchema({
    name: {
        type: String,
        required: true
    },
    email: {
        type: String,
        required: true,
        unique: true,
    },
    password: {
        type: String,
        required: true
    }
});

module.exports = mongoose.model('User', User);
