package datastructures.linkedlists.single;

import datastructures.nodes.single.SingleNode;

public class SingleLinkedList<T> {
    private SingleNode<T> head;
    private SingleNode<T> tail;

    public SingleLinkedList() {
        this.head = null;
        this.tail = null;
    }

    // O(1)
    public void shift(T data) {
        addToStart(data);
    }

    // O(1)
    public void add(T data) {
        addToEnd(data);
    }

    // O(1)
    public T unshift() {
        if (isEmpty()) return null;
        if (this.head == this.tail) {
            return deleteLastSingleElementInList();
        }
        T toBeRemovedData = this.head.getData();
        this.head = this.head.getNext();
        return toBeRemovedData;
    }

    // O(n)
    public T pop() {
        if (isEmpty()) return null;
        if (this.head == this.tail) {
            return deleteLastSingleElementInList();
        }
        SingleNode<T> cursor = this.head;

        while (cursor.getNext() != this.tail) {
            cursor = cursor.getNext();
        }
        T toBeRemovedData = this.tail.getData();
        this.tail = cursor;
        cursor.setNext(null);
        return toBeRemovedData;
    }

    // O(1)
    public void clear() {
        this.head = null;
        this.tail = null;
    }

    // O(1)
    public boolean isEmpty() {
        return this.head == null;
    }

    // O(n)
    public String toString() {
        if (isEmpty()) return "[]";

        SingleNode<T> cursor = this.head;
        String output = "[ Head -> ";
        while (cursor != null) {
            output += cursor.getData().toString() + " -> ";
            cursor = cursor.getNext();
        }
        return output + "Tail -> ]";
    }

    // O(n)
    public boolean addAfter(T data, T newData) {
        if (isEmpty()) {
            initLinkedList(newData);
            return true;
        }
        SingleNode<T> cursor = this.head;
        while (cursor != null && !cursor.getData().equals(data)) {
            cursor = cursor.getNext();
        }
        if (cursor == null) return false;

        if (cursor == this.tail) {
            addToEnd(newData);
        } else {
            SingleNode<T> newNode = new SingleNode<>(newData);
            newNode.setNext(cursor.getNext());
            cursor.setNext(newNode);
        }
        return true;
    }

    // O(n)
    public boolean addBefore(T data, T newData) {
        if (isEmpty()) {
            initLinkedList(newData);
            return true;
        }
        if (this.head.getData().equals(data)) {
            addToStart(newData);
            return true;
        }
        SingleNode<T> cursor = this.head;
        while (cursor != null && cursor.getNext() != null && !cursor.getNext().getData().equals(data)) {
            cursor = cursor.getNext();
        }
        if (cursor == null || cursor.getNext() == null) return false;
        SingleNode<T> newNode = new SingleNode<>(newData);
        newNode.setNext(cursor.getNext());
        cursor.setNext(newNode);
        return true;
    }

    // O(n)
    public boolean delete(T data) {
        if (this.head == this.tail) {
            clear();
            return true;
        }
        if (this.head.getData().equals(data)) {
            unshift();
            return true;
        }
        if (this.tail.getData().equals(data)) {
            pop();
            return true;
        }
        SingleNode<T> cursor = this.head;
        while (cursor != null && cursor.getNext() != null && !cursor.getNext().getData().equals(data)) {
            cursor = cursor.getNext();
        }
        if (cursor == null || cursor.getNext() == null) return false;
        SingleNode<T> toDelete = cursor.getNext();
        cursor.setNext(cursor.getNext().getNext());
        toDelete = null;
        return true;
    }

    // O(1)
    private void initLinkedList(T data) {
        this.head = new SingleNode<>(data);
        this.tail = this.head;
    }

    // O(1)
    private void addToStart(T data) {
        if (isEmpty()) {
            initLinkedList(data);
            return;
        }
        SingleNode<T> newNode = new SingleNode<>(data);
        newNode.setNext(this.head);
        this.head = newNode;
    }

    // O(1)
    private void addToEnd(T data) {
        if (isEmpty()) {
            initLinkedList(data);
            return;
        }
        SingleNode<T> newNode = new SingleNode<>(data);
        this.tail.setNext(newNode);
        this.tail = newNode;
    }

    // O(1)
    private T deleteLastSingleElementInList() {
        T toBeRemovedData = this.head.getData();
        clear();
        return toBeRemovedData;
    }
}
