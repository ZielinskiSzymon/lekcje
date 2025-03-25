public class Guest {
    private String name;
    private String meal;
    private int phoneNumber;
    private boolean isVegan;

    public Guest(String name, String meal, int phoneNumber, boolean isVegan) {
        this.name = name;
        this.meal = meal;
        this.phoneNumber = phoneNumber;
        this.isVegan = isVegan;
    }

    public String getName() {
        return name;
    }

    public String getMeal() {
        return meal;
    }

    public int getPhoneNumber() {
        return phoneNumber;
    }

    public boolean isVegan() {
        return isVegan;
    }

    public void dispalyGusetInformation() {
        System.out.println("Imie: " + name);
        System.out.println("Posilek: " + meal);
        System.out.println("Numer telefonu: " + phoneNumber);
        System.out.println("Czy weganin: " +(isVegan ? "Tak" : "Nie"));
        System.out.println();
    }

}
