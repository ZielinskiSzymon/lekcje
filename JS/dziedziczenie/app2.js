function Osoba(imie){
    this.imie = imie;
}
Osoba.prototype.przedstawSie = function(){
    console.log(`Cześć, jestem ${this.imie}`);
}
const student1 = new Osoba('Jan');

student1.przedstawSie();

student1.hasOwnProperty('imie');
student1.toString();