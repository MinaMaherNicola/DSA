var topKFrequent = function (nums, k) {
	const counterDict = {};

	for (let i = 0; i < nums.length; i++) {
		if (counterDict[nums[i]]) {
			counterDict[nums[i]]++;
		} else {
			counterDict[nums[i]] = 1;
		}
	}

	const items = Object.entries(counterDict);

	items.sort((a, b) => b[1] - a[1]);

	const output = [];
	for (let i = 0; i < k; i++) {
		output.push(items[i][0] * 1);
	}
	return output;
};

console.log(topKFrequent([1, 1, 1, 2, 2, 3], 2));
