let samochody = {
    marka: "Ford",
    model: "Mustang",
    rokProdukcji: 1969,
    kolor: "czarny",
}

function displayCar(car) {
    console.log(`Samochód ${car.marka} ${car.model} wyprodukowany w ${car.rokProdukcji} roku, koloru ${car.kolor}`);
}

displayCar(samochody);