import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int number,
            guess;
        Random rand = new Random();
        number = rand.nextInt(10);


        do {
            System.out.print("Please enter a number between 1 and 10: ");
            guess = sc.nextInt();

            if (number > guess)
                System.out.println("Number is too low!");
            else if (number < guess)
                System.out.println("Number is too high!");
            else
                System.out.println("Congratulations! You guessed it!");
        }while(number != guess);
    }
}