import java.util.*;

public class Main {
    public static void main(String[] args) {
        System.out.println("ArrayList\n\n");
        //arrayList - klasa interfejsu api javy podobna do tablicy mozemy przechowywac obikety
        //wielkosc obiektow
        //arrayList automatycznie jest modyfikowana

        ArrayList<String> nameList = new ArrayList<String>();
        nameList.add("Tadek");
        nameList.add("Janek");
        nameList.add("Borys");

        System.out.println("Mamy tyle elementow: " + nameList.size());
        //wyswietlic jeden element
        System.out.println(nameList.get(1));

        //wypisanie wszystkich z listy
        for (int i = 0; i < nameList.size(); i++) {
            System.out.println(nameList.get(i));
        }
        for (String name : nameList) {
            System.out.println(name);
        }

        System.out.println(nameList);


        //usuwanie
        nameList.remove(1);

        //wstawianie
        nameList.add(1,"Katarzyna");
        for (int i = 0; i < nameList.size(); i++) {
            System.out.println(nameList.get(i));
        }

        System.out.println("\n\nSet\n\n");

        //Set - nie ma duplikatow nie sa uporzadkowane nie ma gwarancji co do kolejnosci
        Set<String> auta = new HashSet<String>();
        auta.add("Audi");
        auta.add("BMW");
        auta.add("Mercedes");
        auta.add("Rower");

        for (String auto : auta) {
            System.out.println(auto);
        }

        auta.add("Rower");
        for (String auto : auta) {
            System.out.println(auto);
        }

        System.out.println("\n\nHashMap\n\n");

        //HashMapa - typ klucz-wartosc jesli dodany klucz ktory istnieje to nowa wartosc zostanie zastapiona poprzednia
        Map<String, String> imieDoAuta = new HashMap<>();

        imieDoAuta.put("Janke", "Audi");
        imieDoAuta.put("Oskar", "Opel");
        imieDoAuta.put("Patryk", "BMW");
        imieDoAuta.put("Filip", "Saxo");

        System.out.println(imieDoAuta.get("Janek"));
        System.out.println(imieDoAuta.isEmpty());
//        imieDoAuta.clear();
        System.out.println(imieDoAuta.size());
        System.out.println(imieDoAuta.containsKey("Janek"));
        System.out.println(imieDoAuta.containsValue("Audi"));

        for (String key : imieDoAuta.keySet()){
            System.out.println(key);
        }

        for (String value : imieDoAuta.values()){
            System.out.println(value);
        }

        Set<String> keys = imieDoAuta.keySet();
        for (String key : keys){
            System.out.println(key);
        }

        Collection<String> values = imieDoAuta.values();
        for (String value : values){
            System.out.println(value);
        }
    }
}