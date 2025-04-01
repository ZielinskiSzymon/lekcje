async function fetchExchangeRates() {
    try {
      const response = await fetch('https://api.nbp.pl/api/exchangerates/tables/A?format=json');
  
      if (!response.ok) {
        throw new Error('Nie udało się pobrać danych z API.');
      }
  
      const data = await response.json();
  
      const rates = data[0].rates;
  
      const selectedCurrencies = ['USD', 'EUR', 'GBP', 'CHF'];
  
      selectedCurrencies.forEach(currency => {
        const rate = rates.find(rate => rate.code === currency);
        if (rate) {
          console.log(`${currency}: ${rate.mid} PLN`);
        } else {
          console.log(`${currency}: Brak danych`);
        }
      });
    } catch (error) {
      console.error('Wystąpił błąd podczas pobierania danych:', error.message);
    }
  }
  
  fetchExchangeRates();
  