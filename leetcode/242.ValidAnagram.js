var isAnagram = function (s, t) {
	const map = {};

	for (let i = 0; i < s.length; i++) {
		map[s[i]] ? map[s[i]]++ : (map[s[i]] = 1);
	}

	for (let i = 0; i < t.length; i++) {
		if (!map[t[i]]) return false;
		map[t[i]]--;
	}
	const vals = Object.values(map);
	return vals.every(v => v === 0);
};
