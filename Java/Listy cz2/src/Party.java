import java.util.*;

public class Party {
    //quest jest prywatne nie widoczne poza klase
    private List<Guest> guests = new ArrayList<>();
    private Set<String> meals = new HashSet<>();
    private Map<Integer, Guest> phoneNumberToGuest = new HashMap<>();

    Scanner scanner = new Scanner(System.in);
    public void addGuest() {
        System.out.println("Podaj imie: ");
        String name = scanner.nextLine();

        System.out.println("podaj poislek: ");
        String meal = scanner.nextLine();

        System.out.println("Numer telefonu");
        int phoneNumber = Integer.parseInt(scanner.nextLine());

        System.out.println("czy jestes weganinem (Y/N)");
        String isVeganString = scanner.nextLine();

        boolean isVegan = isVeganString.equalsIgnoreCase("Y");

        Guest guest = new Guest(name, meal, phoneNumber, isVegan);
        meals.add(meal);
        phoneNumberToGuest.put(phoneNumber, guest);
        guests.add(guest);
    }

    public void displayGuests() {
        for(Guest guest : guests){
            guest.dispalyGusetInformation();
        }
    }
    public void displayMeals() {
        for(String meal : meals){
            System.out.println(meal);
        }
    }
    public void finfGuestByphoneNumber(){
        System.out.println("Podaj numer telefonu: ");
        int phoneNumber = scanner.nextInt();
        scanner.nextLine();
        Guest guest = phoneNumberToGuest.get(phoneNumber);
        if (guest!=null)
            guest.dispalyGusetInformation();
        else
            System.out.println("Nie znaleziono goscia o podanym numerze");
    }

}
