var mergeAlternately = function (word1, word2) {
	let length = Math.max(word1.length, word2.length);
	let output = '';
	for (let i = 0; i < length; i++) {
		if (word1[i]) output += word1[i];
		if (word2[i]) output += word2[i];
	}
	return output;
};
