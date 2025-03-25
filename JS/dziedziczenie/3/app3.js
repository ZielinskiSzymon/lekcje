class Animal{
    constructor(imie, gatunek){
        this.imie = imie;
        this.gatunek = gatunek;
        this.eat = function(){
            console.log(this.imie+' - '+this.gatunek);
        }
    }
}

const dog1 = new Animal('Burek', 'Lablador');
const dog2 = new Animal('Azor', 'Owczarek');
const cat1 = new Animal('Mruczek', 'Dachowiec');

dog1.eat();