var longestConsecutive = function (nums) {
	if (nums.length === 0) return 0;
	if (nums.length === 1) return 1;
	const obj = {};
	[...new Set(nums)].forEach(num => (obj[num] = 1));
	let output = 0;
	for (let i = 0; i < nums.length; i++) {
		let counter = 0;
		if (!obj[nums[i] - 1]) {
			let j = 1;
			while (obj[nums[i] + j]) {
				counter++;
				j++;
			}
			if (output < counter) output = counter;
		}
	}
	return ++output;
};

console.log(longestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]));
