package recursion

func Power(x int, y int) int {
	if y == 0 {
		return 1
	}
	return x * Power(x, y - 1)
}

func Factorial(x int) int {
	if x == 1 {
		return 1
	}

	return x * Factorial(x - 1)
}

func Fib(x int) int {
	if x <= 1 {
		return x
	}
	return Fib(x - 1) + Fib(x - 2)
}