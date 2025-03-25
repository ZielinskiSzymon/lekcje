class Result {
    //metoda statyczna, ktora zwraca nam wygrana lub przegrana
    static moneyWinInGame(result, bid) {
        //jezeli wygrana to zwracamy 3x stawka, jezeli przegrana to 0, jezeli remis to zwroc 1x stawka
        if (result) return 3 * bid;
        else return 0;
    }
    //metoda statyczna, ktora sprawdza czy wygralismy
    static checkWinner(draw) {
        //jezeli wszystkie kolory sa takie same lub wszystkie sa rozne to zwracamy true, w przeciwnym wypadku false
        if ((draw[0] === draw[1] && draw[1] === draw[2]) || (draw[0] !== draw[1] && draw[1] !== draw[2] && draw[0] !== draw[2])) return true;
        else return false;
    }
}