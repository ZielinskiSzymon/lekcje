const mongoose = require('mongoose');
const Schema = new mongoose.Schema({
    name: {
        type: String,
        required: true, // jest wymagany
        unique: true, // musi byc unikaliny
    },
});

module.exports = mongoose.model('Item', Schema); // eksportujemy model Item