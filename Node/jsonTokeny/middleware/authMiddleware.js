const jwt = require('jsonwebtoken');

module.exports = function (req, res, next) {
    const authHeader = req.headers.authorization;

    const token = authHeader && authHeader.split(' ')[1];
    if (!token) {
        return res.sendStatus(401); //Brak tokenu brak dostepu
    }

    try{
        const decoded = jwt.verify(token, process.env.JWT_SECRET); //Weryfikacja tokenu
        req.user = decoded;
        next();
    }
    catch (err) {
        return res.status(403).json({ message: 'Invalid token' }); //Niepoprawny token
    }
}