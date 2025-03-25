public class Main {
    public static void main(String[] args) {
        Die die1 = new Die(6);
        Die die2 = new Die(12);

        System.out.println("Kostki o iloscie scian " + die1.getSides()+" i "+die2.getSides());
        for (int i = 0; i < 5; i++) {
            System.out.println("Kostka 1->" + die1.getValue()+ " Kostka 2->" + die2.getValue());
            die1.roll();
            die2.roll();
        }
    }
}