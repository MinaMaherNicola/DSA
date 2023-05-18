var reverseList = function (head) {
	let left = null;
	let right = head;

	while (right != null) {
		const holder = right.next;
		right.next = left;
		left = right;
		right = holder;
	}
	return left;
};
