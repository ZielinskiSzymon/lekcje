const express = require('express');

const { check } = require('express-validator');

const { getUsers, registerUser } = require('../controllers/userController');

const router = express.Router();

//get
router.get('/', getUsers);

//post
router.post(
    '/register',
    [
        check('name', 'Imię musi mieć min. 3').isLength({ min: 3 }),
        check('email', 'Email jest wymagany').isEmail(),
        check('password', 'Hasło musi mieć min. 6').isLength({ min: 6 })
    ]
    , registerUser
);

module.exports = router;

