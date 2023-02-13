package datastructures.nodes.single;

public class SingleNode<T> {
    private T data;
    private SingleNode<T> next;

    public SingleNode() {
        this.data = null;
        this.next = null;
    }

    public SingleNode(T data, SingleNode next) {
        this.data = data;
        this.next = next;
    }

    public T getData() {
        return data;
    }

    public void setData(T data) {
        this.data = data;
    }

    public SingleNode<T> getNext() {
        return next;
    }

    public void setNext(SingleNode<T> next) {
        this.next = next;
    }
}
