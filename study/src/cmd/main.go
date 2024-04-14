package main

import (
	"fmt"
	"learningDSA/src/internal/sortingAlgorithms"
)

func main() {
	a := []int {5, 2, 7, 1, 0}

	fmt.Println(sortingAlgorithms.MergeSort(a))
}