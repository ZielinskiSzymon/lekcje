import java.util.Random;

public class Die {
    private final Random random = new Random();
    private final int sides;
    private int value;

    public Die(int sides) {
        this.sides = sides;
        roll();
    }

    public void roll() {
        value = random.nextInt(sides) + 1;
    }

    public int getSides() {
        return sides;
    }

    public int getValue() {
        return value;
    }
}
