package recursion

func Power(x int, y int) int {
	if y == 0 {
		return 1
	}
	return x * Power(x, y - 1)
}