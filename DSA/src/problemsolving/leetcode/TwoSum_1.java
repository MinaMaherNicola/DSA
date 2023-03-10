package problemsolving.leetcode;

import java.util.HashMap;
import java.util.Map;

public class TwoSum_1 {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            int missing = target - nums[i];
            if (map.containsKey(missing)) {
                return new int[] { map.get(missing), i };
            }
            map.put(nums[i], i);
        }
        return null;
    }
}
