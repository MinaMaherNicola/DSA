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

func SelectionSort(a []int) {
	for i := 0; i < len(a); i++ {
		selected := i
		for j := i + 1; j < len(a); j++ {
			if a[j] < a[selected] {
				selected = j
			}
		}
		a[i], a[selected] = a[selected], a[i]
	}
}