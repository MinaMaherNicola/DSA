package sortingAlgorithms

func BubbleSort(a []int) {
	for i := len(a) - 1; i > -1; i-- {
		for j := 0; j < i; j++ {
			if a[j] > a[j + 1] {
				holder := a[j]
				a[j] = a[j + 1]
				a[j + 1] = holder
			}
		}
	}
}