package linkedlists

type DoubleNode struct {
	Data int
	Next *DoubleNode
	Prev *DoubleNode
}

type DoubleLinkedList struct {
	Head   *DoubleNode
	Tail   *DoubleNode
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
		l.Head = newNode
		l.Tail = newNode
		return
	}
	newNode.Next = l.Head
	l.Head.Prev = newNode
	l.Head = newNode
}

func (l *DoubleLinkedList) AddLast(d int) {
	defer l.incrementLength()
	if l.IsEmpty() {
		l.AddFirst(d)
		return
	}
	l.Tail.Next = &DoubleNode{
		Data: d,
		Prev: l.Tail,
	}
	l.Tail = l.Tail.Next
}

func (l *DoubleLinkedList) RemoveFirst() (int, bool) {
	if l.IsEmpty() {
		return 0, false
	}
	defer l.decrementLength()
	output := l.Head.Data

	if l.Head == l.Tail {
		l.Clear()
		return output, true
	}
	l.Head = l.Head.Next
	l.Head.Prev = nil
	return output, true
}

func (l *DoubleLinkedList) RemoveLast() (int, bool) {
	if l.IsEmpty() {
		return 0, false
	}
	defer l.decrementLength()
	output := l.Tail.Data

	if l.Head == l.Tail {
		l.Clear()
		return output, true
	}

	l.Tail = l.Tail.Prev
	l.Tail.Next = nil
	return output, true
}

func (l *DoubleLinkedList) Clear() {
	l.Head = nil
	l.Tail = nil
}

func (l *DoubleLinkedList) Remove(d int) bool {
	if l.IsEmpty() {
		return false
	}
	defer l.decrementLength()
	if l.Head.Data == d {
		l.RemoveFirst()
		return true
	}
	if l.Tail.Data == d {
		l.RemoveLast()
		return true
	}
	cursor := l.Head.Next
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

	cursor := l.Head

	for cursor != nil {
		if cursor.Data == d {
			return true
		}
		cursor = cursor.Next
	}
	return false
}

func (l *DoubleLinkedList) IsEmpty() bool {
	return l.Head == nil
}