import javax.swing.*;

public class Main {

    public static double litryFarby(double metry) {
        return metry / 10 * 1.5;
    }

    public static double liczbaGodzin(double metry) {
        return metry / 10 * 8;
    }

    public static double kosztFarby(double litryFarby, double cenaFarby) {
        return litryFarby * cenaFarby;
    }

    public static double kosztRobocizny(double godziny) {
        return godziny * 18;
    }

    public static double kosztCalkowity(double kosztFarby, double kosztRobocizny) {
        return kosztFarby + kosztRobocizny;
    }

    public static void main(String[] args) {
        double cenaFarby;
        int liczbaPokojow;
        double powierzchniaPokojow = 0;

        liczbaPokojow = Integer.parseInt(JOptionPane.showInputDialog("Podaj liczbę pokoi:"));

        cenaFarby = Double.parseDouble(JOptionPane.showInputDialog("Podaj koszt farby za litr:"));

        for (int i = 1; i <= liczbaPokojow; i++) {
            powierzchniaPokojow += Double.parseDouble(
                    JOptionPane.showInputDialog(String.format("Podaj powierzchnię pokoju numer %d:", i))
            );
        }

        String tekst = getString(powierzchniaPokojow, cenaFarby, liczbaPokojow);

        JOptionPane.showMessageDialog(null, tekst);
    }

    private static String getString(double powierzchniaPokojow, double cenaFarby, int liczbaPokojow) {
        double potrzebneLitryFarby = litryFarby(powierzchniaPokojow);
        double potrzebneGodziny = liczbaGodzin(powierzchniaPokojow);
        double kosztFarby = kosztFarby(potrzebneLitryFarby, cenaFarby);
        double kosztRobocizny = kosztRobocizny(potrzebneGodziny);
        double kosztCalkowity = kosztCalkowity(kosztFarby, kosztRobocizny);

        return String.format("""
                        Do pomalowania %d pokoi o łącznej powierzchni %.2f m²
                        Potrzebna ilość farby: %.2f litrów (cena za litr: %.2f zł)
                        Koszt farby: %.2f zł
                        Koszt robocizny: %.2f zł
                        Łączny koszt: %.2f zł""",
                liczbaPokojow, powierzchniaPokojow, potrzebneLitryFarby, cenaFarby,
                                     kosztFarby, kosztRobocizny, kosztCalkowity);
    }
}
