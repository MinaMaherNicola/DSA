package tests

import (
	"learningDSA/src/internal/sortingAlgorithms"
	"testing"
)

func TestIsSortedTrueCase(t *testing.T) {
	a := []int {1, 2, 3, 4, 5, 6, 7, 8}

	v := sortingAlgorithms.IsSorted(a)

	if !v {
		t.Fail()
	}
}

func TestIsSortedFalseCase(t *testing.T) {
	a := []int {1, 2, 3, 4, 5, 6, 7, 8, 2}

	v := sortingAlgorithms.IsSorted(a)

	if v {
		t.Fail()
	}
}

func TestBubbleSort(t *testing.T) {
	a := []int {5, 1, 2, 10, 3, 4, 20, 50, 0}

	sortingAlgorithms.BubbleSort(a)

	if !sortingAlgorithms.IsSorted(a) {
		t.Fail()
	}
}