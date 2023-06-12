var lengthOfLongestSubstring = function (s) {
	if (s.length === 0 || s.length === 1) return s.length;
	const set = new Set();
	let left = 0,
		right = 0,
		maxSize = 0;

	while (right < s.length) {
		let setSize = set.size;
		set.add(s[right]);
		if (set.size > maxSize) {
			maxSize = set.size;
		}
		if (setSize !== set.size) {
			right++;
			continue;
		}
		left++;
		right = left;
		set.clear();
	}
	return maxSize;
};
