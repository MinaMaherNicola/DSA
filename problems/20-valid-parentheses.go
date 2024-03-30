package main

import "fmt"

func main() {
	fmt.Println(isValid("[](){}"))
}

func isValid(s string) bool {
	if len(s) % 2 != 0 {
			return false
	}
	m := map[rune]rune{
		'[': ']',
		'(': ')',
		'{': '}',
	}

	stack := []rune{}

	// O(n)
	for _, c := range s {
		switch c {
			case '[', '{', '(':
				stack = append(stack, m[c])
			default:
				if len(stack) == 0 {
						return false
				}
				if stack[len(stack) - 1] != c {
					return false
				}
				stack = stack[:len(stack) - 1]
		}
	}

	return len(stack) == 0
}