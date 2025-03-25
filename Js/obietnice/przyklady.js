function sprawdz(callback) {
    setTimeout(function() {
        callback();
    }, 1000);
}

sprawdz(function() {
    console.log('Zadanie wykonane!');
});

function pobierzDane(){
    return new Promise(function(resolve, reject){
        let dane = true;
        setTimeout(function(){
            if(dane){
                resolve('Dane pobrane poprawnie!');
            } else {
                reject('Błąd podczas pobierania danych!');
            }
        }, 2000);
    });
}

pobierzDane()
    .then(result => console.log(result))
    .catch(error => console.log(error));