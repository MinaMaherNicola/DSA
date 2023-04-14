var isValid = function (s) {
	const map = { ')': '(', ']': '[', '}': '{' };
	const stack = [];

	for (let i = 0; i < s.length; i++) {
		if (!map[s[i]]) {
			stack.push(s[i]);
			continue;
		}
		if (stack[stack.length - 1] !== map[s[i]]) return false;
		stack.pop();
	}
	return stack.length === 0;
};
