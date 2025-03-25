let i = 1;
document.addEventListener("DOMContentLoaded", addDiv);

document.querySelector("#dodajFilm").addEventListener("click", () => {
    if(document.querySelector("#tytul"+(i-1)).value != "" && document.querySelector("#ocena"+(i-1)).value != "")
        addDiv();
    
});


document.querySelector("#formularzFilmow").addEventListener("submit", (e) => {
    e.preventDefault();
    const filmy = [];


    for(let j = 1; j < i; j++)
        filmy.push({tytuł: document.querySelector("#tytul"+j).value, ocena: parseFloat(document.querySelector("#ocena"+j).value)});
    

    let wynik = document.querySelector("#Wyniki");
    
    wynik.innerHTML = "";
    filmy.forEach(film => {
        if(film.ocena >= 7)
        {
            const li = document.createElement("li");
            li.textContent = film.tytuł;
            wynik.appendChild(li);
        }
    });
    
});
function addDiv() {
    let div = document.createElement("div");

    let label = document.createElement("label");
    label.setAttribute("for", "tytul"+i);
    label.textContent = "Tytuł filmu "+i+":";
    div.appendChild(label);

    let input = document.createElement("input");
    input.setAttribute("type", "text");
    input.setAttribute("id", "tytul"+i);
    input.setAttribute("name", "tytul"+i);
    input.setAttribute("placeholder", "Wpisz tytuł");
    input.setAttribute("required", "");
    div.appendChild(input);

    label = document.createElement("label");
    label.setAttribute("for", "ocena"+i);
    label.textContent = "Ocena:";
    div.appendChild(label);

    input = document.createElement("input");
    input.setAttribute("type", "text");
    input.setAttribute("id", "ocena"+i);
    input.setAttribute("name", "ocena"+i);
    input.setAttribute("placeholder", "Wpisz ocenę");
    input.setAttribute("min", 0);
    input.setAttribute("max", 10);
    input.setAttribute("step", 0.1);
    input.setAttribute("required", "");
    div.appendChild(input);

    document.querySelector("#naDivy").appendChild(div);
    i++;
}
