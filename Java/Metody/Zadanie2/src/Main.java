import java.util.Scanner;

public class Main {
    /**
     * Metoda ta oblicza ile ptrzeba litrow farby na pomalowanie pokoju
     * @return Zwraca litry farby
     * */
    public static double litryFarby(double powierzchnia) {
        return (powierzchnia / 10) * 1.5;
    }

    /**
     * Metoda ta oblicza ile potrzeba godzin aby pomalowac
     * @return zwaraca liczbe godzin
     * */
    public static double liczbaGodzin(double powierzchnia) {
        return (powierzchnia / 10) * 8;
    }

    /**
     * Metoda ta oblicza koszt farby
     * @return zwraca koszty farby
     * */
    public static double kosztFarby(double liczbaFarby, double cenaZaLitr) {
        return liczbaFarby * cenaZaLitr;
    }

    /**
     * Metoda ta oblicza koszt robocizny
     * @return zwraca koszty robocizny
     * */
    public static double kosztRobocizny(double liczbaGodzin, double stawkaZaGodzine) {
        return liczbaGodzin * stawkaZaGodzine;
    }

    /**
     * Metodea liczy całkowity koszt malowania
     * @return zwraca ksoszt
     * */
    public static double lacznyKoszt(double kosztRoboizny,double kosztFarby){
        return kosztFarby + kosztRoboizny;
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Podaj liczbę pokojów do pomalowania: ");
        int pokoje = scanner.nextInt();

        double calkowitaPowierzchnia = 0;
        for (int i = 1; i <= pokoje; i++) {
            System.out.print("Podaj powierzchnię pokoju " + i + " w metrach kwadratowych: ");
            calkowitaPowierzchnia += scanner.nextDouble();
        }

        double litry = litryFarby(calkowitaPowierzchnia);
        double godziny = liczbaGodzin(calkowitaPowierzchnia);
        double kosztyFarby = kosztFarby(litry, 50);
        double kosztRobocizny = kosztRobocizny(godziny,18.00);
        double calkowityKoszt = lacznyKoszt(kosztyFarby,kosztRobocizny);


        
        scanner.close();
    }
}
