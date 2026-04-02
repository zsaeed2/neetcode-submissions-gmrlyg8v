public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int, int> mostFrequent = new PriorityQueue<int, int>();
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (frequency.ContainsKey(num)) {
                frequency[num]++;
            }
            else {
                frequency[num] = 1;
            }
        }

        foreach (var kvp in frequency) {
            mostFrequent.Enqueue(kvp.Key, kvp.Value);
            if (mostFrequent.Count > k) {
                mostFrequent.Dequeue();
            }
        }

        int[] result = new int[k];

        for(int i = 0; i < k; i++) {
            result[i] = mostFrequent.Dequeue();
        }

        return result;
    }
}