class Bank{
    constructor(imie, nazwisko, saldo){
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.saldo = saldo;
    }
    deposit(kwota){
        if(kwota>0 ){
            this.saldo += kwota;
            console.log('Wpłacono '+kwota+' PLN');
        }
    }
    withdraw(kwota){
        if(kwota>0 && kwota<=this.saldo){
            this.saldo -= kwota;
            console.log('Wypłacono '+kwota+' PLN');
        }
    }
}

const konto = new Bank('Jan', 'Kowalski', 1000);

konto.deposit(500);
konto.withdraw(200);