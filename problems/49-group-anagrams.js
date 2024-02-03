var groupAnagrams = function (strs) {
	if (strs.length === 1) return [strs];

	const dict = {};

	for (let i = 0; i < strs.length; i++) {
		const strOrdered = strs[i].split('').sort().join('');

		if (dict[strOrdered]) {
			dict[strOrdered].push(strs[i]);
			continue;
		}
		dict[strOrdered] = [strs[i]];
	}
	return Object.values(dictionary);
};
