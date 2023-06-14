var invertTree = function (root) {
	if (!root) {
		return root;
	}
	const leftHolder = root.left;
	root.left = invertTree(root.right);
	root.right = invertTree(leftHolder);

	return root;
};
