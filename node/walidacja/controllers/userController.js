const User = require('../models/User');

const { validationResult } = require('express-validator');

const getUsers = async (req, res) => {
    try {
        const user = await User.find().select('-password'); // select do wykluczenia hasła
        res.json(user);
    }
    catch (err) {
        console.error(err.message);
        res.status(500).send({ msg: 'Server error' });
    }
};

const registerUser = async (req, res) => {
    const errors = validationResult(req);
    if(!errors.isEmpty()){
        return res.status(400).json({ errors: errors.array() });
    }

    const { name, email, password } = req.body;
    try {
        let user = await User.findOne({ email });
        if(user){
            return res.status(400).json({ msg: 'Użytkownik już istnieje' });
        }
        user = new User({ name, email, password });
        await user.save();
        res.status(201).json({ msg: 'Użytkownik został zarejestrowany' });
    }
    catch (err) {
        res.status(500).send({ msg: 'Błąd serwera' });
    }
};

const loginUser = async (req, res) => {
    const { email, password } = req.body;
    try {
        let user = await User.findOne({
            email
        });
        if(!user){
            return res.status(400).json({ msg: 'Niepoprawne dane logowania' });
        }
        if(password !== user.password){
            return res.status(400).json({ msg: 'Niepoprawne dane logowania' });
        }
        res.json({ msg: 'Zalogowano' });
    }
    catch (err) {
        res.status(500).send({ msg: 'Błąd serwera' });
    }
}

    
module.exports = {
    getUsers,
    registerUser,
    loginUser
};