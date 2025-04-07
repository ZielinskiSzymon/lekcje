const { validationResult } = require('express-validator');
const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');
const User = require('../models/User');

//rejestracja
exports.register = async (req, res) => {
    const errors = validationResult(req);
    if(!errors.isEmpty()) {
        return res.status(422).json({ errors: errors.array() });
    }
    const {username, password} = req.body;
    
    try{
        const hashedPassword = await bcrypt.hash(password, 10); //Szyfrowanie hasla

        const user = new User({
            username,
            password: hashedPassword
        });

        await user.save();
        res.status(201).json({ message: 'User created' });
    }
    catch (err) {
        res.status(500).json({ message: 'Server error' });
    }
}

//logowanie
exports.login = async (req, res) => {
    const errors = validationResult(req);
    if(!errors.isEmpty()) {
        return res.status(400).json({ errors: errors.array() });
    }
    const {username, password} = req.body;

    try{
        const user = await User.findOne({ username });
        if(!user) {
            return res.status(401).json({ message: 'User not found' });
        }

        const match = await bcrypt.compare(password, user.password);
        if(!match) {
            return res.status(401).json({ message: 'Invalid credentials' });
        }

        //token generowanie
        const token = jwt.sign({ id: user._id }, process.env.JWT_SECRET, { expiresIn: '1h' });
        res.json({message: 'Logged in', token });
    }catch(err){
        res.status(500).json({ message: 'Something went wrong' });
    }
}

exports.protected = (req, res) => {
    res.json({ message: 'you have acces to pretected route', user: req.user });
}

