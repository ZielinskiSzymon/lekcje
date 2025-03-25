import java.util.Scanner;
import java.lang.Math;

public class Main {
    public static void main(String[] args) {
//        Scanner scanner = new Scanner(System.in);
//        int height = scanner.nextInt();
//
//        for (int i = 0; i < height; i++) {
//            for (int j = 0; j < height; j++) {
//                if (i==0||i==height-1|| i+j == height-1)
//                    System.out.print("* ");
//                else
//                    System.out.print("  ");
//            }
//            System.out.println();
//        }

//        for (int i = 0; i < 24; i++) {
//            for (int j = 0; j < 60; j++) {
//                for (int k = 0; k < 60; k++) {
//                    if (i<10)
//                        System.out.print("0"+i);
//                    else
//                        System.out.print(i);
//
//                    System.out.print(" : ");
//                    if (j<10)
//                        System.out.print("0"+j);
//                    else
//                        System.out.print(j);
//
//                    System.out.print(" : ");
//                    if (k<10)
//                        System.out.print("0"+k);
//                    else
//                        System.out.print(k);
//
//                    System.out.println();
//
//                    try {
//                        Thread.sleep(1000);
//                    }catch (InterruptedException e){
//                        System.out.println();
//                    }
//
//                }
//            }
//        }

        System.out.print("Liczby pierwsze: ");
        for (int i = 2; i < 100; i++) {
            boolean pierwsza = true;
            for (int j = 2; j < Math.sqrt(i) ; j++) {
                if (i%j == 0){
                    pierwsza = false;
                    break;
                }
            }
            if (pierwsza)
                System.out.print(i+", ");
        }
        System.out.println();
    }
}