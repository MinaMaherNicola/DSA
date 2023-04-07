var groupAnagrams = function (strs) {
	const anagramObj = {};
	for (let i = 0; i < strs.length; i++) {
		const orderedStr = strs[i].split('').sort().join('');
		if (!anagramObj[orderedStr] && anagramObj[orderedStr] !== 0) {
			anagramObj[orderedStr] = [strs[i]];
		} else {
			anagramObj[orderedStr].push(strs[i]);
		}
	}
	return Object.values(anagramObj);
};
