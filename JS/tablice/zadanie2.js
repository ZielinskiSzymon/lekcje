console.log('Zadanie 2');

const filmy = [
    {tytuł: "Ojciec Mateusz", ocena: 10,gatunek: "Kryminał"},
    {tytuł: "Harry Potter", ocena: 9.2,gatunek: "Powieść"},
    {tytuł: "Matrix", ocena: 8,gatunek: "Sci-fi"},
    {tytuł: "Ojciec Chrzestny", ocena: 7.6,gatunek: "Dramat"},
    {tytuł: "Policjanci i polijantki", ocena: 6.6,gatunek: "Kryminał"},
];

const wysokoOcenioneFilmy = filmy.filter(film => film.ocena > 8);
console.log(wysokoOcenioneFilmy);

const uproszczoneFilmy = wysokoOcenioneFilmy.map(film => ({
    tytuł: film.tytuł,
    ocena: film.ocena
}));
console.log(uproszczoneFilmy);

