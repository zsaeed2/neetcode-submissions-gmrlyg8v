class Solution {
    public boolean hasDuplicate(int[] nums) {
        HashSet<Integer> detectDuplicates = new HashSet<Integer>();
        for (int i : nums) {
            if (detectDuplicates.contains(i)) {
                return true;
            }
            detectDuplicates.add(i);
        }
        return false;
    }
}