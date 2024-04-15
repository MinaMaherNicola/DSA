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

func InsertionSort(a []int) {
	l := len(a)
	for i := 1; i < l; i++ {
			current := a[i]
			j := i - 1
			for j >= 0 && a[j] > current {
					a[j+1] = a[j]
					j--
			}
			a[j+1] = current
	}
}

func MergeSort(a []int) []int {
	l := len(a)
	if l <= 1 {
		return a
	}

	mid := l / 2
	left := MergeSort(a[0:mid])
	right := MergeSort(a[mid:l])
	return merge(left, right)
}

func merge(left, right []int) []int {
	leftLength := len(left)
	rightLength := len(right)
	newLength := leftLength + rightLength
	newSlice := make([]int, newLength)

	rightPointer := 0
	leftPointer := 0
	newSlicePointer := 0

	for leftPointer < leftLength && rightPointer < rightLength {
		if left[leftPointer] >= right[rightPointer] {
			newSlice[newSlicePointer] = right[rightPointer]
			rightPointer++
		} else {
			newSlice[newSlicePointer] = left[leftPointer]
			leftPointer++
		}
		newSlicePointer++
	}

	if leftPointer != leftLength {
		copy(newSlice[newSlicePointer:], left[leftPointer:])
	}

	if rightPointer != rightLength {
		copy(newSlice[newSlicePointer:], right[rightPointer:])
	}

	return newSlice
}

func QuickSort(a []int) []int {
	if len(a) <= 1 {
			return a
	}
	p := len(a) - 1
	l := 0

	for r := 0; r < p; r++ {
			if a[r] <= a[p] {
					if r != l {
							a[r], a[l] = a[l], a[r] 
					}
					l++
			}
	}

	a[l], a[p] = a[p], a[l]

	QuickSort(a[:l])
	QuickSort(a[l+1:])

	return a
}
