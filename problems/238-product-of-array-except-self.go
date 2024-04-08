package main

import "fmt"

func main() {
 fmt.Println(productExceptSelf([]int{1, 2, 3, 4}))
}

func productExceptSelf(nums []int) []int {
	l := len(nums)
	if l == 0 || l == 1 {
		return nums
	}

	output := make([]int, l, l)

	left := make([]int, l, l)
	left[0] = 1
	right := make([]int, l, l)
	right[l - 1] = 1

	prefix := 1
	for i := 0; i < l; i++ {
		left[i] = prefix
		prefix *= nums[i]
	}

	postfix := 1
	for i := l - 1; i > -1; i-- {
		right[i] = postfix
		postfix *= nums[i]
	}

	for i := 0; i < l; i++ {
		output[i] = left[i] * right[i]
	}
	return output
}