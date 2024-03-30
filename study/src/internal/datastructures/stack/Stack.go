package stack

import "learningDSA/src/internal/datastructures/linkedlists"

type Stack struct {
	l linkedlists.SingleLinkedList
}

func (s *Stack) Push(d int) {
	s.l.AddFirst(d)
}

func (s *Stack) Pop() (int, bool) {
	return s.l.RemoveFirst()
}

func (s *Stack) Peek() (int, bool) {
	return s.l.PeekFirst()
}

func (s *Stack) String() string {
	return s.l.String()
}

func (s *Stack) Length() int {
	return s.l.Length
}