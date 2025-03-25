const item = require('../models/item');

// pobieranie wszsytkich przedmiotow
exports.getItems = async (req, res) => {
    const items = await item.find();
    res.json(items);
}

// dodawanie przedmiotu
exports.addItem = async (req, res) => {
    const newItem = new item(req.body);
    const savedItem = await newItem.save();
    res.json(savedItem);
}

// aktualizacja przedmiotu
exports.updateItem = async (req, res) => {
    try {
        const updateItem = await item.findByIdAndUpdate(req.params.id, req.body, { new: true });
        res.json(updateItem);
    }
    catch (err) {
        res.status(500).json("Błąd podczas aktualizacji przedmiotu");
    }
}

// usuwanie przedmiotu
exports.deleteItem = async (req, res) => {
    try {
        await item.findByIdAndDelete(req.params.id);
        res.json({ message: "Przedmiot został usunięty" });
    }
    catch (err) {
        res.status(500).json("Błąd podczas usuwania przedmiotu");

    }
}

// odpalenie serwera
exports.runServer = async (req, res) => {
    res.json({ message: "Server is running" });
}