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

        PriorityQueue<int, int> mostFrequentElements = new PriorityQueue<int, int>();

        foreach(var kvp in frequencies) {
            mostFrequentElements.Enqueue(kvp.Key, kvp.Value);
            if (mostFrequentElements.Count > k) {
                mostFrequentElements.Dequeue();
            }
        }

        int[] kMostFrequent = new int[k];

        for(int i = 0; i < k; i++) {
            kMostFrequent[i] = mostFrequentElements.Dequeue();
        }

        return kMostFrequent;
    }
}
