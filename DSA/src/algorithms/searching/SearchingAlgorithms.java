package algorithms.searching;

public class SearchingAlgorithms {
    public static int binarySearch(int[] arr, int target) {
        int left = 0, right = arr.length - 1, mid = right / 2;

        while (left < arr.length && right >= 0) {
            if (arr[mid] == target) return mid;
            if (arr[mid] > target) {
                right = mid - 1;
                mid = (right + left) / 2;
                continue;
            }
            if (arr[mid] < target) {
                left = mid + 1;
                mid = (right + left) / 2;
            }
        }
        return -1;
    }
}
