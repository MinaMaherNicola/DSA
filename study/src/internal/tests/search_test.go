package tests

import (
	searchingalgorithms "learningDSA/src/internal/searchingAlgorithms"
	"testing"
)

func TestBinarySearchEmptyCase(t *testing.T) {
	a := []int {}

	r := searchingalgorithms.BinarySearch(a, 1)

	if r != -1 {
		t.Fail()
	}
	
}

func TestBinarySearchSingleItemCaseValid(t *testing.T) {
	a := []int {1}

	r := searchingalgorithms.BinarySearch(a, 1)

	if r != 0 {
		t.Fail()
	}
}

func TestBinarySearchSingleItemCaseInvalid(t *testing.T) {
	a := []int {1}

	r := searchingalgorithms.BinarySearch(a, 4)

	if r != -1 {
		t.Fail()
	}
}

func TestBinarySearchEnd(t *testing.T) {
	a := []int {1, 2, 3, 4, 5, 6, 900, 5000}

	r := searchingalgorithms.BinarySearch(a, 5000)

	if r != 7 {
		t.Fail()
	}
}

func TestBinarySearchStart(t *testing.T) {
	a := []int {1, 2, 3, 4, 5, 6, 900, 5000}

	r := searchingalgorithms.BinarySearch(a, 1)

	if r != 0 {
		t.Fail()
	}
}

func TestBinarySearchOddMid(t *testing.T) {
	a := []int {1, 2, 3, 4, 5}

	r := searchingalgorithms.BinarySearch(a, 3)

	if r != 2 {
		t.Fail()
	}
}

func TestBinarySearchEvenMid(t *testing.T) {
	a := []int {1, 2, 4, 5}

	r := searchingalgorithms.BinarySearch(a, 4)

	if r != 2 {
		t.Fail()
	}
}