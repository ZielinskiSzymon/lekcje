import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int product = 0;
        while (product<100){
            System.out.print("Please enter number: ");
            product = sc.nextInt() * 10;
        }
    }
}