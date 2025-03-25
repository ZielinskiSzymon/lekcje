public class Main {
    public static void odwroc(int tab[], int i){
        if(i>=tab.length/2){
            return;
        }
        int temp = tab[i];
        tab[i]=tab[tab.length-1-i];
        tab[tab.length-1-i] = temp;

        odwroc(tab, i+1);

    }
    public static void main(String[] args) {
        int tab[] = {1,2,3,4,5,6,7,8,9};

        odwroc(tab, 0);

        for (int i = 0; i < tab.length; i++) {
            System.out.print(tab[i]+", ");
        }
        System.out.println();
    }
}