import java.util.Arrays;

public class Main {
    static int[] quickSort(int[] arr, int left, int right)
    {
        if (left < right) {
            int i = left, j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j) {
                while (arr[i] < pivot) {
                    i++;
                }
                while (arr[j] > pivot) {
                    j--;
                }

                if (i <= j) {
                    swap(arr, i, j);
                    i++;
                    j--;
                }
            }

            if (left < j) {
                quickSort(arr, left, j);
            }
            if (i < right) {
                quickSort(arr, i, right);
            }
        }

        return arr;
    }

    static void swap(int[] arr, int a, int b) {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    public static void main(String[] args) {
        int[] arr = {78, 45, 12, 89, 34, 67, 23, 90, 11, 3, 8, 99, 21, 54, 76, 43, 87, 32, 65, 10};

        quickSort(arr, 0, arr.length - 1);
        System.out.println(Arrays.toString(arr));
    }
}
