import express from 'express';
import mongoose from 'mongoose';
import cors from 'cors';
import dotenv from 'dotenv';
import userRoutes from "./routes/userRoutes.js";
import { loginUser } from './controllers/userController.js';

dotenv.config({ path: "./config/.env" });

mongoose.connect(process.env.MONGO_URI)
    .then(() => console.log("Połączono z bazą danych"))
    .catch(error => {
        console.log("BŁąd połączenia z bazą", error)
        process.exit(1);
    });

const app = express();
    
app.use(cors());
app.use(express.json());

app.use('/api/users', userRoutes);

app.use('/api/login', loginUser);

const PORT = process.env.PORT || 3000;

app.listen(PORT, () => console.log(`Serwer działa na porcie ${PORT}`));