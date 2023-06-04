var maxArea = function (height) {
	let output = 0,
		left = 0,
		right = height.length - 1;
	while (left < right && right > left) {
		const current = Math.min(height[left], height[right]) * (right - left);
		if (output < current) output = current;

		if (height[left] > height[right]) right--;
		else left++;
	}
	return output;
};
