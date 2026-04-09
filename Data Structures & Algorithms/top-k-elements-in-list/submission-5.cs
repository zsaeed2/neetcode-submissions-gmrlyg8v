public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        foreach(int num in nums) {
            if (!frequencies.ContainsKey(num)) {
                frequencies[num] = 1;
            }
            else {
                frequencies[num]++;
            }
        }

        PriorityQueue<int, int> sorter = new PriorityQueue<int, int>();
        foreach (var kvp in frequencies) {
            sorter.Enqueue(kvp.Key, kvp.Value);
            if (sorter.Count > k) {
                sorter.Dequeue();
            }
        }

        int[] result = new int[k];
        for(int i = 0; i < k; i++) {
            result[i] = sorter.Dequeue();
        }

        return result;
    }
}
