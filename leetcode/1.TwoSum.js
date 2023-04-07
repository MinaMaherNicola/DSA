var twoSum = function (nums, target) {
	const map = {};
	for (let i = 0; i < nums.length; i++) {
		if (map[target - nums[i]] !== undefined) return [i, map[target - nums[i]]];

		if (!map[nums[i]]) {
			map[nums[i]] = i;
		}
	}
};
console.log(twoSum([2, 7], 9));
