package main

import (
	"fmt"
	"learningDSA/src/internal/sortingAlgorithms"
)

func main() {
	a := []int {5, 1, 2, 10, 3, 4, 20, 50, 0}

	sortingAlgorithms.SelectionSort(a)

	fmt.Println(a)
}