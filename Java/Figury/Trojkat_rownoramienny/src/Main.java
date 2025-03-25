import java.util.Scanner;

public class Main {
    public static void Spacja(int s){
        for (int i = 0; i < s; i++)
            System.out.print(" ");
    }
    public static void Gwiazdka(int g){
        for (int i = 0; i < g; i++)
            System.out.print("* ");
    }
    public static void Rysuj(int y){
        for (int i = 0; i < y; i++) {
            Spacja((y-i-1)*2);
            Gwiazdka((2*i+1));
            System.out.println();
        }
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int y;
        System.out.print("Podaj wsokosc ");
        y = scanner.nextInt();
        Rysuj(y);
    }
}