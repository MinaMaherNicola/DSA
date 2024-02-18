package recursion_tests

import (
	"fmt"
	"learningDSA/src/internal/recursion"
	"testing"
)


func TestPower(t *testing.T) {
	total := recursion.Power(2, 3)

	fmt.Println(total)
	if total != 8 {
		t.Error()
	}
}