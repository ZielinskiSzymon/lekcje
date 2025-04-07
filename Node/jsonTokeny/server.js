const express = require('express');
const connectDB = require('./config/db');

const authRoutes = require('./routes/authRoutes');

require('dotenv').config({path: './config/.env'});

const app = express();
connectDB();

app.use(express.json());
app.use('/api', authRoutes);

const PORT = process.env.PORT || 5000;
app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});