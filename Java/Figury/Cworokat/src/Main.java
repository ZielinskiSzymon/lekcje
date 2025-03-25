import java.util.Scanner;

public class Main {
    public static void Rysuj(int x,int y){
        for (int i = 0; i < y; i++) {
            for (int j = 0; j < x; j++) {
                System.out.print("* ");
            }
            System.out.println();
        }
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int x,y;

        System.out.print("Podaj x ");
        x = scanner.nextInt();
        System.out.print("Podaj y ");
        y = scanner.nextInt();
        Rysuj(x,y);
    }
}