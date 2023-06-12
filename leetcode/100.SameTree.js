var isSameTree = function (p, q) {
	if (!p && !q) {
		return true;
	}
	if (!p || !q) {
		return false;
	}
	if (p.val !== q.val) {
		return false;
	}
	if (isSameTree(p.left, q.left) === false || isSameTree(p.right, q.right) === false) {
		return false;
	}
	return true;
};
