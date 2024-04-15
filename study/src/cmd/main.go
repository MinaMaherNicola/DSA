package main

import (
	"fmt"
	"learningDSA/src/internal/sortingAlgorithms"
)

func main() {
	a := []int {9, 8, 7, 6, 5, 4, 3, 2, 1}

	sortingAlgorithms.QuickSort(a)
	fmt.Println(a)
}