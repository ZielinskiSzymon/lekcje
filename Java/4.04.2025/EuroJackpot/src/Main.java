import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) throws FileNotFoundException {
        File plik = new File("pbnumbers.txt");
        Scanner skaner = new Scanner(plik);

        List<List<Integer>> wszystkieLosowania = new ArrayList<>();
        Map<Integer, Integer> czestoscLiczbGlownych = new HashMap<>();
        Map<Integer, Integer> czestoscPowerBall = new HashMap<>();
        Map<Integer, Integer> ostatnieWystapienie = new HashMap<>();

        for (int i = 1; i <= 69; i++) {
            czestoscLiczbGlownych.put(i, 0);
        }
        for (int i = 1; i <= 39; i++) {
            czestoscPowerBall.put(i, 0);
        }

        int numerLosowania = 0;
        while (skaner.hasNextLine()) {
            numerLosowania++;
            String linia = skaner.nextLine();
            String[] liczby = linia.split(" ");
            List<Integer> losowanie = new ArrayList<>();

            for (int i = 0; i < 5; i++) {
                int liczba = Integer.parseInt(liczby[i]);
                losowanie.add(liczba);
                czestoscLiczbGlownych.put(liczba, czestoscLiczbGlownych.get(liczba) + 1);
                ostatnieWystapienie.put(liczba, numerLosowania);
            }

            int powerBall = Integer.parseInt(liczby[5]);
            losowanie.add(powerBall);
            czestoscPowerBall.put(powerBall, czestoscPowerBall.get(powerBall) + 1);

            wszystkieLosowania.add(losowanie);
        }
        skaner.close();

        List<Map.Entry<Integer, Integer>> top10Najczestsze = czestoscLiczbGlownych.entrySet()
                .stream()
                .sorted(Map.Entry.<Integer, Integer>comparingByValue().reversed())
                .limit(10)
                .collect(Collectors.toList());

        List<Map.Entry<Integer, Integer>> top10Najrzadsze = czestoscLiczbGlownych.entrySet()
                .stream()
                .sorted(Map.Entry.comparingByValue())
                .limit(10)
                .collect(Collectors.toList());

        for (int i = 1; i <= 69; i++) {
            ostatnieWystapienie.putIfAbsent(i, 0);
        }

        List<Map.Entry<Integer, Integer>> najdluzszaNieobecnosc = ostatnieWystapienie.entrySet()
                .stream()
                .sorted(Map.Entry.comparingByValue())
                .limit(10)
                .collect(Collectors.toList());

        System.out.println("10 najczęściej losowanych liczb głównych:");
        for (Map.Entry<Integer, Integer> entry : top10Najczestsze) {
            System.out.println(entry.getKey() + ": " + entry.getValue() + " razy");
        }

        System.out.println("\n10 najrzadziej losowanych liczb głównych:");
        for (Map.Entry<Integer, Integer> entry : top10Najrzadsze) {
            System.out.println(entry.getKey() + ": " + entry.getValue() + " razy");
        }

        System.out.println("\n10 liczb, które nie pojawiły się od najdłuższego czasu:");
        for (Map.Entry<Integer, Integer> entry : najdluzszaNieobecnosc) {
            int ostatnieLosowanie = entry.getValue();
            if (ostatnieLosowanie == 0) {
                System.out.println(entry.getKey() + ": nigdy nie wylosowany");
            } else {
                System.out.println(entry.getKey() + ": ostatnio w losowaniu " + ostatnieLosowanie);
            }
        }

        System.out.println("\nLiczba wystąpień każdej liczby głównej (1-69):");
        for (int i = 1; i <= 69; i++) {
            System.out.print(i + ": " + czestoscLiczbGlownych.get(i) + " | ");
            if (i % 5 == 0) System.out.println();
        }

        System.out.println("\n\nLiczba wystąpień każdego numeru PowerBall (1-39):");
        for (int i = 1; i <= 39; i++) {
            System.out.print(i + ": " + czestoscPowerBall.get(i) + " | ");
            if (i % 5 == 0) System.out.println();
        }
    }
}