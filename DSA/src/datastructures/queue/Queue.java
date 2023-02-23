package datastructures.queue;

import datastructures.linkedlists.single.SingleLinkedList;

public class Queue<T> {
    private final SingleLinkedList<T> list;

    public Queue() {
        list = new SingleLinkedList<>();
    }

    public void enqueue(T data) {
        list.add(data);
    }

    public T dequeue() {
        return list.unshift();
    }

    public T peek() {
        return this.list.firstItem();
    }

    public String toString() {
        return this.list.toString();
    }
}
