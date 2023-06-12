var maxProfit = function (prices) {
	if (prices.length === 1) return 0;
	let left = 0,
		right = 1;
	let profit = 0;
	while (right < prices.length) {
		let currentProfit = prices[right] - prices[left];
		if (currentProfit > profit) {
			profit = currentProfit;
		}
		if (prices[right] < prices[left]) {
			left = right;
		}
		right++;
	}
	return profit;
};
