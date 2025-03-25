document.addEventListener("DOMContentLoaded", generowanie);

function generowanie() {
    let liczbyContainer = document.querySelector(".liczby");
    let columns = [];

    // Tworzymy 12 kolumn
    for (let i = 0; i < 12; i++) {
        let column = document.createElement("div");
        column.classList.add("column");
        columns.push(column);
        liczbyContainer.appendChild(column);
    }

    // Dodajemy liczby do kolumn
    for (let i = 0; i < 37; i++) {
        let element = document.createElement("div");
        element.classList.add("element");

        if (i === 0) {
            element.classList.add("green");
        } else if (i % 2 !== 0) {
            element.classList.add("red");
        } else {
            element.classList.add("black");
        }

        element.textContent = i;

        // Dodajemy element do odpowiedniej kolumny
        let columnIndex = i % 12;
        columns[columnIndex].appendChild(element);
    }
}
