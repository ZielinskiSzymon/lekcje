let trCounter = 1;

document.addEventListener("DOMContentLoaded", ()=>{
    if(localStorage.getItem("rachunki") != null){
        let arr = JSON.parse(localStorage.getItem("rachunki"));
        arr.forEach(el => {
            appendTr(el[0], el[1]);
            trCounter++;
        });
    }

    sum();
})
function appendTr(nazwa, cena){
    let tr = document.createElement("tr")
    tr.className="tr2";
    tr.id="tr"+trCounter;
    tr.innerHTML=`
        <td class="nazwy">${nazwa}</td>
        <td class="ceny">${parseFloat(cena).toFixed(2)} zł</td>   
        <td><button class="btns2">Usuń</button></td>
    `
    document.querySelector("table").appendChild(tr);
    saveInLocalStorage();
    sum();
}

function createTr(nazwa, cena){
    let tr = document.createElement("tr")
    tr.className="tr2";
    tr.id="tr"+trCounter;
    tr.innerHTML=`
        <td class="nazwy">${nazwa}</td>
        <td class="ceny">${parseFloat(cena).toFixed(2)} zł</td>
        <td><button class="btns2">Usuń</button></td>
    `

    document.querySelector("table").appendChild(tr);
    sum();
    saveInLocalStorage();
}

function removeTr(e){
    let tr = e.target.parentElement.parentElement;
    tr.remove();
    sum();
    saveInLocalStorage();
}

function sum(){
    let ceny = document.querySelectorAll(".ceny");
    let suma = 0;
    ceny.forEach(cena => {
        if(cena.parentElement.style.display == "table-row" || cena.parentElement.style.display == "")
            suma += parseFloat(cena.innerText.replace(" zł", ""));
    });
    document.querySelector("#kosztCalkowity").innerText = suma.toFixed(2) + " zł";
}

function sortDescending(){
    let ceny = document.querySelectorAll(".ceny");
    let trs = document.querySelectorAll(".tr2");
    let arr = [];
    ceny.forEach((cena, index) => {
        arr.push([parseFloat(cena.innerText), trs[index]]);
    });
    arr.sort((a, b) => b[0] - a[0]);
    arr.forEach((el) => {
        document.querySelector("table").appendChild(el[1]);
    });
    sum();
}

function sortAscending(){
    let ceny = document.querySelectorAll(".ceny");
    let trs = document.querySelectorAll(".tr2");
    let arr = [];
    ceny.forEach((cena, index) => {
        arr.push([parseFloat(cena.innerText), trs[index]]);
    });
    arr.sort((a, b) => a[0] - b[0]);
    arr.forEach((el) => {
        document.querySelector("table").appendChild(el[1]);
    });
    sum();
}

function search(){
    let nazwy = document.querySelectorAll(".nazwy");
    let szukaj = document.querySelector("#search").value;
    nazwy.forEach(nazwa => {
        if(nazwa.innerText.toLowerCase().includes(szukaj.toLowerCase())){
            nazwa.parentElement.style.display="table-row";
        }else{
            nazwa.parentElement.style.display="none";
        }
    });
    sum();
}

function usunFiltr(){
    let nazwy = document.querySelectorAll(".nazwy");

    nazwy.forEach(nazwa => {
        nazwa.parentElement.style.display="table-row";
    });
    sum();
}

function exportToCsv(){
    let nazwy = document.querySelectorAll(".nazwy");
    let ceny = document.querySelectorAll(".ceny");

    let csv = "\uFEFFUsługa;Koszt\n";
    nazwy.forEach((nazwa, index) => {
        csv += `${nazwa.innerText};${ceny[index].innerText}\n`;
    });
    let filename = "rachunki.csv";
    downloadCsv(csv, filename);
}

function downloadCsv(csv, filename){
    let csvFile;
    let downloadLink;

    csvFile = new Blob([csv], {type: "text/csv;charset=utf-8;"});
    downloadLink = document.createElement("a");
    downloadLink.download = filename;
    downloadLink.href = window.URL.createObjectURL(csvFile);
    downloadLink.style.display = "none";
    document.body.appendChild(downloadLink);

    downloadLink.click();
}
function saveInLocalStorage(){
    let nazwy = document.querySelectorAll(".nazwy");
    let ceny = document.querySelectorAll(".ceny");

    let arr = [];
    nazwy.forEach((nazwa, index) => {
        arr.push([nazwa.innerText, ceny[index].innerText]);
    });
    localStorage.setItem("rachunki", JSON.stringify(arr));
}

document.querySelector("#add").addEventListener("click", ()=>{
    let cena = document.querySelector("#kwota");
    cena.value = parseFloat(cena.value).toFixed(2);
    let nazwa = document.querySelector("#name");
    if(nazwa.value == "" || cena.value <= 0){
        nazwa.style.border="1px solid red";
        cena.style.border="1px solid red";
        return;
    }else{
        nazwa.style.border="1px solid #eee";
        cena.style.border="1px solid #eee";        
        createTr(nazwa.value, cena.value);
        trCounter++;
    }
})

document.querySelector("table").addEventListener("click", (e)=>{
    if(e.target.className == "btns2"){
        removeTr(e);
    }
})

document.querySelector("#sortAscending").addEventListener("click", sortAscending);
document.querySelector("#sortDescending").addEventListener("click", sortDescending);
document.querySelector("#filtr").addEventListener("click", search);
document.querySelector("#usunFiltr").addEventListener("click", usunFiltr);
document.querySelector("#eksport").addEventListener("click", exportToCsv);