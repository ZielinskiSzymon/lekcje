const apiUrl = "https://api.nbp.pl/api/exchangerates/tables/A?format=json";

async function fetchCurrencyRates() {
    try {
        const response = await fetch(apiUrl);
        if (!response.ok) {
            throw new Error("Błąd podczas pobierania danych z API");
        }
        const data = await response.json();
        updateTable(data[0].rates);
        populateCurrencySelectors(data[0].rates);
    } catch (error) {
        const resultElement = document.getElementById("conversionResult");
        resultElement.textContent = "Nie udało się pobrać danych: " + error.message;
    }
}

function populateCurrencySelectors(rates) {
    const fromCurrency = document.getElementById("fromCurrency");
    const toCurrency = document.getElementById("toCurrency");

    fromCurrency.innerHTML = "";
    toCurrency.innerHTML = "";

    rates.forEach(rate => {
        const optionFrom = document.createElement("option");
        optionFrom.value = rate.mid;
        optionFrom.textContent = rate.code;
        fromCurrency.appendChild(optionFrom);

        const optionTo = document.createElement("option");
        optionTo.value = rate.mid;
        optionTo.textContent = rate.code;
        optionFrom.selected = rate.code === "USD";
        toCurrency.appendChild(optionTo);
    });
}

function updateTable(rates) {
    const tableContainer = document.getElementById("currencyTable");
    const tableHeader = `
        <table>
            <tr>
                <th>Nazwa waluty</th>
                <th>Kod waluty</th>
                <th>Kurs średni</th>
            </tr>`;
    let tableRows = rates.map(rate => `
        <tr>
            <td>${rate.currency}</td>
            <td>${rate.code}</td>
            <td>${rate.mid}</td>
        </tr>`).join("");
    tableContainer.innerHTML = tableHeader + tableRows + "</table>";
}

function convertCurrency() {
    const fromCurrency = document.getElementById("fromCurrency");
    const toCurrency = document.getElementById("toCurrency");
    const amount = document.getElementById("amount").value;
    const resultElement = document.getElementById("conversionResult");

    if (!amount || isNaN(amount)) {
        resultElement.textContent = "Wprowadź poprawną kwotę.";
        return;
    }

    const fromRate = parseFloat(fromCurrency.value);
    const toRate = parseFloat(toCurrency.value);
    const convertedAmount = (amount * fromRate) / toRate;

    resultElement.textContent = `Przeliczona kwota: ${convertedAmount.toFixed(2)}`;
}

document.getElementById("refreshButton").addEventListener("click", fetchCurrencyRates);
document.getElementById("convertButton").addEventListener("click", convertCurrency);

// Pobierz dane przy pierwszym załadowaniu strony
fetchCurrencyRates();
