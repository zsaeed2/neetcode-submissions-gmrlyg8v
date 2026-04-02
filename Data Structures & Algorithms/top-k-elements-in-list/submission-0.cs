public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numsCount = new Dictionary<int, int>();

        foreach(int num in nums) {
            if (!numsCount.ContainsKey(num)) {
                numsCount[num] = 0;
            }

            numsCount[num]++;
        }

        List<int>[] frequencies = new List<int>[nums.Length + 1];
        for(int i = 0; i < frequencies.Length; i++) {
            frequencies[i] = new List<int>();
        }

        foreach (var kvp in numsCount) {
            frequencies[kvp.Value].Add(kvp.Key);
        }

        int[] ans = new int[k];
        int index = 0;
        for(int j = frequencies.Length - 1; j >= 0 && index < k; j--) {
            foreach (int n in frequencies[j]) {
                ans[index] = n;
                index++;
                if (index == k) {
                    return ans;
                }
            }
        }
        return ans;
    }
}
