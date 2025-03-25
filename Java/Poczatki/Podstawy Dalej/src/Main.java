import java.util.Objects;
import java.util.Scanner;
import static java.lang.Math.*;


public class Main {
//    static  void rysuj_gwiadki(int n){
//        for (int i = 0; i < n; i++) {
//            System.out.print("*");
//        }
//        System.out.println();
//    }

    static void tempeatura(int p, int k, int r){

        for (int i = p; i < k; i+=r) {
            System.out.println(i+"°C to "+round((i*9/5)+32)+"°F");
        }



    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

//        int a,b;
//                    // Math.nazwa_metody(argumenty)
//
//        System.out.println("Podaj liczbe a -> ");
//        a = scanner.nextInt();
//        System.out.println("Podaj liczbe b -> ");
//        b = scanner.nextInt();
//
//        System.out.println("A do potegi B = "+ pow(a,b));
//        System.out.println("Wartosc bezwzgledna A = "+ abs(a));
//        System.out.println("Pierwiastekz liczby A podniesianej do potegi B "+ sqrt(pow(a,b)));

//        String imie;
//
//        imie = scanner.nextLine();
//
//        System.out.println("Imie -> " + imie);

//        double L1,L2;
//
//        System.out.println("Podaj pierwsza liczbe.");
//        L1 = scanner.nextDouble();
//
//        System.out.println("Podaj pdruga liczbe.");
//        L2 = scanner.nextDouble();
//
//        System.out.println("L1 + L2 ="+ (L1+L2));
//        System.out.println("L1 - L2 ="+ (L1-L2));
//        System.out.println("L1 / L2 ="+ (L1/L2));
//        System.out.println("L1 * L2 ="+ (L1*L2));

//        int a,b;String imie;
//
//        System.out.println("Podaj imie");
//        imie = scanner.nextLine();
//        System.out.println("Podaj a");
//        a = scanner.nextInt();
//        System.out.println("Podaj b");
//        b = scanner.nextInt();
//
//
//
//        if (a>b)
//            System.out.println(a+" jest wieksze od "+b);
//        else if (a==b)
//            System.out.println(a+" jest rowne "+b);
//        else
//            System.out.println(b+" jest wieksze od "+a);
//
//
//
//
//        if (Objects.equals(imie, "Szymon") || Objects.equals(imie, "szymon"))
//            System.out.println("Cześć " + imie);
//        else
//            System.out.println("Przykro mi ale cie nie znam");
//        rysuj_gwiadki(55);

        int p,k,r;

        System.out.println("Podaj od ilu");
        p = scanner.nextInt();
        System.out.println("Podaj do ilu");
        k = scanner.nextInt();
        System.out.println("Podaj co ile");
        r = scanner.nextInt();
        tempeatura(p,k,r);
    }
}