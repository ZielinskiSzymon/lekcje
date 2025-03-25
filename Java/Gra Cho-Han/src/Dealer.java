public class Dealer {
    private Die die1;
    private Die die2;
    private int die1Value;
    private int die2Value;

    public Dealer() {
        this.die1 = new Die(6);
        this.die2 = new Die(6);
    }

    public void rollDice() {
        this.die1Value = die1.roll();
        this.die2Value = die2.roll();
    }

    public String getChoOrHan() {
        int sum = die1Value + die2Value;
        return (sum % 2 == 0) ? "Cho" : "Han";
    }

    public int getDie1Value() {
        return die1Value;
    }

    public int getDie2Value() {
        return die2Value;
    }
}
