package linkedlists

import (
	"fmt"
	"strings"
)

type DoubleNode struct {
	Data int
	Next *DoubleNode
	Prev *DoubleNode
}

type DoubleLinkedList struct {
	head   *DoubleNode
	tail   *DoubleNode
	Length int
}

func (l *DoubleLinkedList) incrementLength() {
	l.Length++
}

func (l *DoubleLinkedList) decrementLength() {
	l.Length--
}

func (l *DoubleLinkedList) AddFirst(d int) {
	defer l.incrementLength()
	newNode := &DoubleNode{
		Data: d,
	}
	if l.IsEmpty() {
		l.head = newNode
		l.tail = newNode
		return
	}
	newNode.Next = l.head
	l.head.Prev = newNode
	l.head = newNode
}

func (l *DoubleLinkedList) AddLast(d int) {
	defer l.incrementLength()
	if l.IsEmpty() {
		l.AddFirst(d)
		return
	}
	l.tail.Next = &DoubleNode{
		Data: d,
		Prev: l.tail,
	}
	l.tail = l.tail.Next
}

func (l *DoubleLinkedList) RemoveFirst() (int, bool) {
	if l.IsEmpty() {
		return 0, false
	}
	defer l.decrementLength()
	output := l.head.Data

	if l.head == l.tail {
		l.Clear()
		return output, true
	}
	l.head = l.head.Next
	l.head.Prev = nil
	return output, true
}

func (l *DoubleLinkedList) RemoveLast() (int, bool) {
	if l.IsEmpty() {
		return 0, false
	}
	defer l.decrementLength()
	output := l.tail.Data

	if l.head == l.tail {
		l.Clear()
		return output, true
	}

	l.tail = l.tail.Prev
	l.tail.Next = nil
	return output, true
}

func (l *DoubleLinkedList) Clear() {
	l.head = nil
	l.tail = nil
}

func (l *DoubleLinkedList) Remove(d int) bool {
	if l.IsEmpty() {
		return false
	}
	defer l.decrementLength()
	if l.head.Data == d {
		l.RemoveFirst()
		return true
	}
	if l.tail.Data == d {
		l.RemoveLast()
		return true
	}
	cursor := l.head.Next
	for cursor != nil {
		if cursor.Data == d {
			cursor.Prev.Next = cursor.Next
			cursor.Next.Prev = cursor.Prev
			cursor = nil
			return true
		}
		cursor = cursor.Next
	}
	return false
}

func (l *DoubleLinkedList) Contains(d int) bool {
	if l.IsEmpty() {
		return false
	}

	cursor := l.head

	for cursor != nil {
		if cursor.Data == d {
			return true
		}
		cursor = cursor.Next
	}
	return false
}

func (l *DoubleLinkedList) IsEmpty() bool {
	return l.head == nil
}

func (l *DoubleLinkedList) String() string {
	if l.IsEmpty() {
		return "Head-> nil <-Tail"
	}

	var builder strings.Builder
	builder.WriteString("[nill ")
	cursor := l.head
	for cursor != nil {
		builder.WriteString(fmt.Sprintf("<-%d-> ", cursor.Data))
		cursor = cursor.Next
	}
	builder.WriteString("nil]")

	return builder.String()
}