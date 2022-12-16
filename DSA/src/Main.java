import DataStructures.Arrays.DynamicArrays.DynamicArray;

public class Main {
    public static void main(String[] args) {
        var dynamicArray = new DynamicArray<>();

        dynamicArray.add(0);
        dynamicArray.add(1);
        dynamicArray.add(2);
        dynamicArray.add(3);
        dynamicArray.add(4);
        dynamicArray.add(5);
        dynamicArray.add(6);
        dynamicArray.deleteElementAtIndex(0);
        dynamicArray.printArray();


        System.out.println(dynamicArray.getElement(7));
    }
}