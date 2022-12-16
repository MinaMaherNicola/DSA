package DataStructures.Arrays.DynamicArrays;

import java.util.Arrays;

public class DynamicArray<T> {
    private  T[] array;
    public DynamicArray() {
        array = (T[]) new Object[0];
    }

    // O(1)
    public T getElement(int i) {
        try {
            return array[i];
        } catch (ArrayIndexOutOfBoundsException ex) {
            throw ex;
        }
    }

    // O(1)
    public int getLength() {
        return array.length;
    }

    // O(n)
    public void add(T item) {
        array = Arrays.copyOf(array, array.length + 1);
        array[array.length - 1] = item;
    }

    // O(n)
    public void shift(T item) {
        T[] newArray = (T[])new Object[array.length + 1];
        newArray[0] = item;
        System.arraycopy(array, 0, newArray, 1, newArray.length - 1);
        array = newArray;
    }

    public void deleteElementAtIndex(int i) {
        if (i < 0 || i >= array.length) {
            throw new ArrayIndexOutOfBoundsException();
        }
        var newArray = (T[]) new Object[array.length - 1];
        System.arraycopy(array, 0, newArray, 0, i);
        System.arraycopy(array, 0, newArray, 0, (array.length - i) - 1 );
        array = newArray;
    }

    // O(n)
    public int getIndexOfElement(T item) {
        for (int i = 0; i < array.length; i++) {
            if (array[i] == item) {
                return i;
            }
        }
        return -1;
    }

    public void printArray() {
        for (T t : array) {
            System.out.print(t + ", " );
        }
        System.out.println();
    }
}
