document.querySelector("#formularzFilmow").addEventListener("submit", (e) => {
    e.preventDefault();

    const filmy = [
        {tytuł: document.querySelector("#tytul1").value, ocena: parseFloat(document.querySelector("#ocena1").value)},
        {tytuł: document.querySelector("#tytul2").value, ocena: parseFloat(document.querySelector("#ocena2").value)},
        {tytuł: document.querySelector("#tytul3").value, ocena: parseFloat(document.querySelector("#ocena3").value)},
    ];

    const filmyPowyzej7 = filmy.filter(film => film.ocena > 7);

    const listaTytulow = filmyPowyzej7.map(film => film.tytuł);

    const listaWynikow = document.querySelector("#Wyniki");

    listaWynikow.innerHTML = "";
    listaTytulow.forEach(tytul => {
        const li = document.createElement("li");
        li.textContent = tytul;
        listaWynikow.appendChild(li);
    });
});

