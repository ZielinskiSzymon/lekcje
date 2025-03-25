function generateBoxes(count) {
    for (let i = 0; i < count; i++) {
        let box = document.createElement('div');
        box.className = 'box';
        box.textContent = i + 1;
        document.querySelector("#numbers").appendChild(box);
    }
}

generateBoxes(49);
const selected = [];
const randomNumbers = [];

document.querySelector("#numbers").addEventListener('click', function (e) {
    if (e.target.className.includes('box')) {
        if (selected.length >= 6 && !e.target.classList.contains('selected')) {
            alert('Możesz wybrac tylko 6 liczb');
            return;
        }
        e.target.classList.toggle('selected');
        const number = parseInt(e.target.textContent);
        if (selected.includes(number)) {
            selected.splice(selected.indexOf(number), 1);
        } else {
            selected.push(number);
        }
    }
});

let all = 0;
let counter0 = 0;
let counter1 = 0;
let counter2 = 0;
let counter3 = 0;
let counter4 = 0;
let counter5 = 0;
let counter6 = 0;

document.querySelector(".button").addEventListener('click', function () {
    document.querySelector("#wylosowaneLiczby").innerHTML = '';
    document.querySelector("#twojeLiczby").innerHTML = '';
    randomNumbers.length = 0;

    if (selected.length > 5) {
        document.querySelectorAll('.h1').forEach(element => {
            element.style.display = 'block';
        });
        while (randomNumbers.length < 6) {
            const number = Math.floor(Math.random() * 49) + 1;
            if (!randomNumbers.includes(number)) {
                randomNumbers.push(number);
                const div = document.createElement('div');
                div.textContent = number;
                div.className = 'box2';
                document.querySelector("#wylosowaneLiczby").appendChild(div);
            }
        }

        selected.forEach(number => {
            const div = document.createElement('div');
            div.textContent = number;
            div.className = 'box2';
            document.querySelector("#twojeLiczby").appendChild(div);
        });

        let counter = 0;
        randomNumbers.forEach(number => {
            if (selected.includes(number)) {
                counter++;
                const div = document.createElement('div');
                div.textContent = number;
                div.className = 'box2';
                document.querySelector("#h221").appendChild(div);
            }
        });

        const wybrane = selected.filter((number) => selected.includes(number));

        for (let i = 0; i< wybrane.length; i++) {
            let div = document.createElement('div');
            div.textContent = wybrane[i];
            div.className = 'box2';
            document.querySelector("#h222").appendChild(div);

        }

        document.querySelector("#h21").textContent = "Zgadłeś " + counter + " liczb";

        if (counter == 0) {
            counter0++;
        }
        if (counter == 1) {
            counter1++;
        }
        if (counter == 2) {
            counter2++;
        }
        if (counter == 3) {
            counter3++;
        }
        if (counter == 4) {
            counter4++;
        }
        if (counter == 5) {
            counter5++;
        }
        if (counter == 6) {
            counter6++;
        }

        all = counter0 + counter1 + counter2 + counter3 + counter4 + counter5 + counter6;

        wygrane();

        document.querySelectorAll('.box.selected').forEach(box => {
            box.classList.remove('selected');
        });
        selected.length = 0;
    } else {
        alert('Wybierz 6 liczb');
    }

    function wygrane() {
        document.querySelector("#h22").innerHTML = "Trafiłeś 1 liczbe " + counter1 + " razy<br>" + "Trafiłeś 2 liczby " + counter2 + " razy<br>" + "Trafiłeś 3 liczby " + counter3 + " razy<br>" + "Trafiłeś 4 liczby " + counter4 + " razy<br>" + "Trafiłeś 5 liczb " + counter5 + " razy<br>" + "Trafiłeś 6 liczb " + counter6 + " razy<br>" + "Wszystkich gier " + all + " razy<br>";
        
    }
});