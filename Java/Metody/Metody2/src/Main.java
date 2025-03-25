public class Main {
    //komentaz javados nalezy dokumentowc piszac komentarze
    // przed definicjami metod naley umiescic krotkie objasnienie co dana metoda robi
    // komentarz tego typu moga byc wczytywane i przetwarzane za pomoca programu javadoc
    // ktory generuje dokumnetacje w formie html

    /// metoda deep wyswietla komunikat a nastepnie wywołuje metode deeper
    public static void deep(){
        System.out.println("Poczatek w metodzie deep");
        deeper();
        System.out.println("Koniec w metodzie deep");
    }

    ///Metoda deeper wywołana przez metode deep
    public static void deeper(){
        System.out.println("W metodzie deeper");
    }

    public static void main(String[] args) {
        System.out.println("Poczatek w metodzie main");
        deep();
        System.out.println("Koniec w metodzie main");

    }
}