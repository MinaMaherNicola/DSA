package linkedlists

import (
	"fmt"
	"strings"
)

type Node struct {
	Data int
	Next *Node
}

type SingleLinkedList struct {
	head *Node
	tail *Node
}

func (l *SingleLinkedList) IsEmpty() bool {
	return l.head == nil
}

func (l *SingleLinkedList) AddFirst(d int) {
	if l.head == nil {
		l.initiateList(d)
		return
	}
	newNode := &Node{
		Data: d,
		Next: l.head,
	}
	l.head = newNode
}

func (l *SingleLinkedList) AddLast(d int) {
	if l.head == nil {
		l.initiateList(d)
		return
	}
	l.tail.Next = &Node{
		Data: d,
	}
	l.tail = l.tail.Next
}

func (l *SingleLinkedList) RemoveLast() (int, bool) {
	if l.head == nil {
		return 0, false
	}
	if l.head == l.tail {
		output := l.head.Data
		l.Clear()
		return output, true
	}
	cursor := l.head
	for cursor != nil && cursor.Next != l.tail {
		cursor = cursor.Next
	}
	output := cursor.Next.Data
	l.tail = cursor
	cursor.Next = nil
	return output, true
}

func (l *SingleLinkedList) RemoveFirst() (int, bool) {
	if l.head == nil {
		return 0, false
	}
	if l.head == l.tail {
		output := l.head.Data
		l.Clear()
		return output, true
	}
	output := l.head.Data
	l.head = l.head.Next
	return output, true
}

func (l *SingleLinkedList) Contains(d int) bool {
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

func (l *SingleLinkedList) Remove(d int) bool {
	if l.IsEmpty() || !l.Contains(d) {
		return false
	}
	if l.head.Data == d {
		l.RemoveFirst()
		return true
	}
	if l.tail.Data == d {
		l.RemoveLast()
		return true
	}
	prevCursor := l.head
	cursor := l.head.Next
	for cursor != nil {
		if cursor.Data == d {
			prevCursor.Next = cursor.Next
			cursor.Next = nil
		}
		cursor = cursor.Next
		prevCursor = prevCursor.Next
	}
	panic("Code should not fall through here!")
}

func (l *SingleLinkedList) Clear() {
	l.head = nil
	l.tail = nil
}

func (l *SingleLinkedList) initiateList(d int) {
	l.head = &Node{
		Data: d,
	}
	l.tail = l.head
}

func (l *SingleLinkedList) String() string {
	if l.IsEmpty() {
		return "Head-> nil <-Tail"
	}

	var builder strings.Builder
	builder.WriteString("[")
	cursor := l.head
	for cursor != nil {
		builder.WriteString(fmt.Sprintf("%d-> ", cursor.Data))
		cursor = cursor.Next
	}
	builder.WriteString("nil]")

	return builder.String()
}