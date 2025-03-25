class Animal{
    constructor(nazwa, wiek){
        this.nazwa = nazwa;
        this.wiek = wiek;
    }
    breathe(){
        console.log("Zwierze oddycha");
        
    }
}
const ziwerze = new Animal('Kot', 5);

ziwerze.breathe();
class Mammal extends Animal{
    constructor(nazwa, wiek, hairs){
        super(nazwa, wiek);
        this.hairs = hairs;
    }
}

const ssak = new Mammal('Kot', 5, 'długi');
ssak.breathe();

class Human extends Mammal{
    constructor(nazwa, wiek, hairs, language){
        super(nazwa, wiek, hairs);
        this.language = language;
    }
    speak(){
        console.log('Człowiek mówi');
    }
}

const murzyn = new Human('Jan', 30, 'czarne', 'angielski');