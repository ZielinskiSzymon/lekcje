import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;

public class Main {
    static boolean Z3_1(int num){
        if (num < 0) return false;

        int temp = (int)Math.sqrt(num);

        if (temp * temp == num){
            return true;
        }
        return false;
    }
    public static void main(String[] args) throws FileNotFoundException {
        FileReader fileReader = new FileReader("liczby.txt");
        Scanner scanner = new Scanner(fileReader);

        int counter = 0;

        while (scanner.hasNext()){
            if(Z3_1(Integer.parseInt(scanner.nextLine()))){
                counter++;
            }
        }

        System.out.println("Zadanie 3.1 -> " + counter);
    }
}