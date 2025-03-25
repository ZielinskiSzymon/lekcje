public class Main {
    public static String bin(int liczba){
        String wBin="";

        while(liczba>0){
            int rem = liczba%2;
            liczba = (liczba-rem)/2;
            wBin+=rem;
        }
        return wBin;
    }

    public static String oct(int liczba){
        String wOct="";

        while(liczba>0){
            int rem = liczba%7;
            liczba = (liczba-rem)/8;
            wOct+=rem;
        }
        return wOct ;
    }
    public static String hex(int liczba){
        String wHex="";

        while(liczba>0){
            int rem = liczba%15;
            liczba = (liczba-rem)/8;
            wHex+=rem;
        }
        return wHex ;
    }
    public static String naSystem(int liczba, int system){
        switch (system){
            case 2 -> {
                return bin(liczba);
            }
            case 8->{
             return oct(liczba);
            }
            case 16 -> {
                return hex(liczba);
            }
            default-> {
                return  "Niepoprawny system";
            }

        }
    }
    public static void main(String[] args) {

        System.out.println(naSystem(15, 16));

    }
}