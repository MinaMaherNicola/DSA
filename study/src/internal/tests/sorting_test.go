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

func TestSelectionSort(t *testing.T) {
	a := []int {5, 1, 2, 10, 3, 4, 20, 50, 0}

	sortingAlgorithms.SelectionSort(a)

	if !sortingAlgorithms.IsSorted(a) {
		t.Fail()
	}
}

func TestInsertionSort(t *testing.T) {
	a := []int {5, 1, 2, 10, 3, 4, 20, 50, 0}

	sortingAlgorithms.InsertionSort(a)

	if !sortingAlgorithms.IsSorted(a) {
		t.Fail()
	}
}

func TestMergeSort_BestCase(t *testing.T) {
	a := []int {0, 1, 2, 3, 4, 5, 6}

	if !sortingAlgorithms.IsSorted(sortingAlgorithms.MergeSort(a)) {
		t.Fail()
	}
}

func TestMergeSort_WorstCase(t *testing.T) {
	a := []int {9, 8, 7, 6, 5, 4, 3, 2, 1}

	if !sortingAlgorithms.IsSorted(sortingAlgorithms.MergeSort(a)) {
		t.Fail()
	}
}

func TestMergeSort_Average(t *testing.T) {
	a := []int {5, 1, 2, 10, 3, 4, 20, 50, 0}

	if !sortingAlgorithms.IsSorted(sortingAlgorithms.MergeSort(a)) {
		t.Fail()
	}
}