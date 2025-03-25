public class Main {
    /// Metoda do wyswietlania
    public static  void displayValue(int num){
        System.out.println(num);
    }
    /**
     * Metoda przyjmuje dwa argumenty typu double i wyswietla ich sume
     * @param num1 pierwsza liczba
     * @param num2 druga liczba
     * 
     * */
    public static void showSum(double num1,double num2){
        double sum = num1 + num2;
    }
    public static void main(String[] args) {
        int x=10;

        System.out.println("Przekazywanie do metod");
        displayValue(x);
        displayValue(5);
        displayValue(x*4);
        displayValue((int) Math.pow(x,2));
        displayValue(x/3);

        displayValue(Integer.parseInt("800"));


        showSum(14,4);
    }
}