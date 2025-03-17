require('dotenv').config({ path: './config/.env' });
const express = require('express');
const mongoose = require('mongoose');
const itemRoutes = require('./routes/itemRoutes');
const bodyParser = require('body-parser');

const app = express();

app.use(bodyParser.json());

mongoose.connect(process.env.MONGO_URI, {})
.then(() => {
    console.log('Połączono z bazą danych');
})
.catch((err) => {
    console.log('Błąd połączenia', err);
});
-
// dodanie routera

app.use('/api', itemRoutes);

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
    console.log(`Serwer działa na porcie ${PORT}`);
});