import java.util.Random;

public class Die {
    private final Random random = new Random();
    private final int sides;

    public Die(int sides) {
        this.sides = sides;
    }

    public int roll() {
        return random.nextInt(sides) + 1;
    }
}
