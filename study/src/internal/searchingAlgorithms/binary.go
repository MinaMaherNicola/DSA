package searchingalgorithms

func BinarySearch(a []int, target int) int {
	if len(a) == 0 {
		return -1
	}
	l := 0
	r := len(a) - 1
	m := (r + l) / 2
	for l <= r {
		if a[m] == target {
			return m
		}
		if a[m] > target {
			r = m - 1
		} else {
			l = m + 1
		}
		m = (r + l) / 2
	}
	return -1
}