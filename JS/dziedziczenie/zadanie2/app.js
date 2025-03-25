class Person{
    constructor(imie, wiek){
        this.imie = imie;
        this.wiek = wiek;
    }
    greet(){
        console.log(`Witaj ${this.imie} masz ${this.wiek} lat.`);
    }
}

class Employee extends Person{
    constructor(imie, wiek, stanowisko){
        super(imie, wiek, this.greet());
        this.stanowisko = stanowisko;
    }
    work(){
        console.log('GRacuje na stanowisku: '+this.stanowisko);
    }
}

class Menager extends Employee{
    constructor(imie, wiek, stanowisko, dzial){
        super(imie, wiek, stanowisko, this.greet());
        this.dzial = dzial;
    }
}

