package sortingAlgorithms

func IsSorted(a []int) bool {
	for i := 0; i < len(a) - 1; i++ {
		if a[i] > a[i + 1] {
			return false
		}
	}
	return true
}