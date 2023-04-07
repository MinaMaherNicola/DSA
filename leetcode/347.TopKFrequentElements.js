var topKFrequent = function (nums, k) {
	const frequency = {};
	nums.forEach(n => (frequency[n] ? frequency[n]++ : (frequency[n] = 1)));
	const r = Object.entries(frequency).sort((a, b) => b[1] - a[1]);
	return r.splice(0, k).map(x => +x[0]);
};
