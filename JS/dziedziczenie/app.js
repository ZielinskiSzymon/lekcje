function Student(imie, wiek, kierunek) {
    this.imie = imie;
    this.wiek = wiek;
    this.kierunek = kierunek;
}   
Student.prototype.przedstawSie = function() {
    console.log(`Cześć, jestem ${this.imie}, mam ${this.wiek} lat i studiuję na kierunku ${this.kierunek}`);
}

let student1 = new Student('Jan', 20, 'Informatyka');

student1.przedstawSie()