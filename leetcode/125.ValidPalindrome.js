var isPalindrome = function (s) {
	if (s.length === 1) return true;
	if (s.length === 0) return true;
	s = s.toLowerCase();
	let left = 0,
		right = s.length - 1;
	while (left < right) {
		while (s[left] && !s[left].match(/[A-Za-z0-9]/)) {
			left++;
		}
		while (s[right] && !s[right].match(/[A-Za-z0-9]/)) {
			right--;
		}
		if (s[left] !== s[right]) return false;
		left++;
		right--;
	}
	return true;
};
