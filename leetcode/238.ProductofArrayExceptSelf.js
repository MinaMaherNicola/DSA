var productExceptSelf = function (nums) {
	const output = [];

	// calculate prefix
	let prefix = 1;
	for (let i = 0; i < nums.length; i++) {
		output[i] = prefix;
		prefix *= nums[i];
	}

	// calculate postfix
	let postfix = 1;
	for (let i = nums.length - 1; i >= 0; i--) {
		output[i] *= postfix;
		postfix *= nums[i];
	}
	return output;
};

console.log(productExceptSelf([1, 2, 3, 4]));
