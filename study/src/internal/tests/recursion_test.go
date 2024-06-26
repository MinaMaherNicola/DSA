package tests

import (
	"learningDSA/src/internal/recursion"
	"testing"
)


func TestPower(t *testing.T) {
	total := recursion.Power(2, 3)

	if total != 8 {
		t.Error()
	}
}

func TestFactorial(t *testing.T) {
	fact := recursion.Factorial(9)

	if fact != 362880 {
		t.Error()
	}
}

func TestFib(t *testing.T) {
	fib := recursion.Fib(20)

	if fib != 6765 {
		t.Error()
	}
}