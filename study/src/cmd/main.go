package main

import (
	"fmt"
	"learningDSA/src/internal/datastructures/linkedlists"
)

func main() {
	l := linkedlists.SingleLinkedList{}

	l.AddFirst(1)
	l.AddFirst(2)
	l.AddLast(4)
	l.Remove(4)
	fmt.Println(l.String())
}