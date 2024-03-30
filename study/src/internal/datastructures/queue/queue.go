package queue

import "learningDSA/src/internal/datastructures/linkedlists"

type Queue struct {
	list linkedlists.DoubleLinkedList
}

func (q *Queue) Enqueue(d int) {
	q.list.AddLast(d)
}

func (q *Queue) Dequeue() (int, bool) {
	return q.list.RemoveFirst()
}

func (q *Queue) GetLength() int {
	return q.list.Length
}

func (q *Queue) Clear() {
	q.list.Clear()
}

func (q *Queue) String() string {
	return q.list.String()
}