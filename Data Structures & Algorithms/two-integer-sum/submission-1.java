class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> counterPart = new HashMap<Integer, Integer>();

        for (int i = 0; i < nums.length; i++) {
            int currValue = nums[i];
            int difference = target - currValue;

            if (counterPart.containsKey(difference)) {
                return new int[] { counterPart.get(difference), i};
            }

            counterPart.put(currValue, i);
        }

        return new int[] {};
    }
}
