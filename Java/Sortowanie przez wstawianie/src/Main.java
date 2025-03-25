import java.util.Arrays;

public class Main {
    static int[] SwapSort(int[] arr){
        int n = arr.length;
        for (int i = 0; i < n; i++) {
            int j = i;
            int temp = arr[j];
            while((j>0) && (arr[j-1] > temp)){
                arr[j] = arr[j-1];
                j--;
            }
            arr[j]=temp;
        }
        return arr;
    }
    public static void main(String[] args) {
        int[] arr = {1,64,3,84,23,67,12,5,25,87};
        arr = SwapSort(arr);
        System.out.println(Arrays.toString(arr));
    }
}