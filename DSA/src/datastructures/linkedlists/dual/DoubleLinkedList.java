package datastructures.linkedlists.dual;

import datastructures.nodes.dual.DoubleNode;

public class DoubleLinkedList<T> {
    private DoubleNode<T> head;
    private DoubleNode<T> tail;

    public DoubleLinkedList() {
        this.head = null;
        this.tail = null;
    }

    // O(1)
    public void shift(T data) {
        if (this.head == null) {
            init(data);
            return;
        }
        addToStart(data);
    }

    // O(1)
    public void append(T data) {
        if (this.head == null) {
            init(data);
            return;
        }
        addToEnd(data);
    }

    // O(1)
    public T unshift() {
        if (isEmpty()) return null;
        T toBeRemovedItem = this.head.getData();
        if (this.head == this.tail) {
            clear();
        } else {
            deleteFromStart();
        }
        return toBeRemovedItem;
    }

    // O(1)
    public T pop() {
        if (isEmpty()) return null;
        T toBeRemovedItem = this.tail.getData();
        if (this.head == this.tail) {
            clear();
        } else {
            deleteFromEnd();
        }
        return toBeRemovedItem;
    }

    // O(n)
    public void deleteData(T data) {
        if (isEmpty() || !doesExist(data)) return;
        if (this.head.getData().equals(data)) {
            deleteFromStart();
            return;
        }
        if (this.tail.getData().equals(data)) {
            deleteFromEnd();
            return;
        }
        DoubleNode<T> cursor = this.head;
        while (cursor != null) {
            if (cursor.getData().equals(data)) break;
            cursor = cursor.getNext();
        }
        cursor.getPrev().setNext(cursor.getNext());
        cursor.getNext().setPrev(cursor.getPrev());
        cursor = null;
    }

    // O(n)
    public String toString() {
        String output = "Next: [ Head -> ";

        DoubleNode<T> cursor = this.head;
        while (cursor != null) {
            output += cursor.getData().toString() + " -> ";
            cursor = cursor.getNext();
        }
        output += "Tail -> ]\n";
        output += "Prev: [ Tail -> ";
        cursor = this.tail;
        while (cursor != null) {
            output += cursor.getData() + " -> ";
            cursor = cursor.getPrev();
        }
        output += "Head -> ]";
        return output;
    }

    // O(1)
    public boolean isEmpty() {
        return this.head == null;
    }

    // O(1)
    public void clear() {
        this.head = null;
        this.tail = null;
    }

    // O(n)
    public boolean doesExist(T data) {
        if (isEmpty()) return false;
        DoubleNode<T> cursor = this.head;
        while (cursor != null) {
            if (cursor.getData().equals(data)) return true;
            cursor = cursor.getNext();
        }
        return false;
    }

    private void addToStart(T data) {
        DoubleNode<T> newNode = new DoubleNode<>(data);
        newNode.setNext(this.head);
        this.head.setPrev(newNode);
        this.head = newNode;
    }

    private void deleteFromStart() {
        this.head = this.head.getNext();
        this.head.setPrev(null);
    }

    private void addToEnd(T data) {
        DoubleNode<T> newNode = new DoubleNode<>(data);
        this.tail.setNext(newNode);
        newNode.setPrev(this.tail);
        this.tail = newNode;
    }

    private void deleteFromEnd() {
        this.tail = this.tail.getPrev();
        this.tail.setNext(null);
    }

    private void init(T data) {
        this.head = new DoubleNode<>(data);
        this.tail = head;
    }
}
