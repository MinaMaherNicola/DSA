package datastructures.stack;

import datastructures.linkedlists.single.SingleLinkedList;

public class Stack<T> {
    private SingleLinkedList<T> list;

    public Stack() {
        list = new SingleLinkedList<>();
    }

    public void push(T item) {
        list.shift(item);
    }

    public T pop() {
        return list.unshift();
    }

    public T peek() {
        return list.firstItem();
    }
}
