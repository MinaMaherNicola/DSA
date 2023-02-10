package datastructures.arrays.dynamic;
import java.util.Arrays;

public class DynamicArray<T> {
    private T[] array;

    public DynamicArray(T[] array) {
        this.array = array;
    }

    public DynamicArray() {
        clear();
    }

    public void add(T item) {
        T[] newArray = Arrays.copyOf(array, array.length + 1);
        newArray[newArray.length - 1] = item;
        array = newArray;
    }

    public void shift(T item) {
        T[] newArray = (T[]) new Object[array.length + 1];
        newArray[0] = item;
        System.arraycopy(array, 0, newArray, 1, array.length);
        array = newArray;
    }

    public T unshift() {
        if (array.length == 0) return null;
        T removedItem = array[0];
        if (array.length == 1) {
            clear();
            return removedItem;
        }
        T[] newArray = (T[]) new Object[array.length - 1];
        System.arraycopy(array, 1, newArray, 0, newArray.length);
        array = newArray;
        return removedItem;
    }

    public T pop() {
        if (array.length == 0) return null;
        T removedItem = array[array.length - 1];
        if (array.length == 1) {
            clear();
            return removedItem;
        }
        T[] newArray = (T[]) new Object[array.length - 1];
        System.arraycopy(array, 0, newArray, 0, array.length - 1);
        array = newArray;
        return removedItem;
    }

    public T removeAtIndex(int index) {
        if (index < 0 || index >= array.length) return null;
        if (index == 0) return unshift();
        if (index == array.length - 1) return pop();

        T[] newArray = (T[]) new Object[array.length - 1];
        System.arraycopy(array, 0, newArray, 0, index);
        System.arraycopy(array, index + 1, newArray, index, newArray.length - index);
        T removedItem = array[index];
        array = newArray;
        return removedItem;
    }

    public int indexOf(T item) {
        for (int i = 0; i < array.length; i++) {
            if (array[i].equals(item)) {
                return i;
            }
        }
        return -1;
    }
    public boolean removeItem(T item) {
        return removeAtIndex(indexOf(item)) != null;
    }

    public boolean exists(T item) {
        for (T a : array) {
            if (a.equals(item)) {
                return true;
            }
        }
        return false;
    }

    public void clear() {
        array = (T[]) new Object[0];
    }

    public String toString() {
        return Arrays.toString(array);
    }
}
