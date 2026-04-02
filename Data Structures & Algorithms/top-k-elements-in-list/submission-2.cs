public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, List<int>> frequency = new Dictionary<int, List<int>>();
        int[] result = new int[k];

        foreach (int num in nums.Distinct()) {
            int numOccurence = nums.Where(x => x == num).Count();
            if(!frequency.ContainsKey(numOccurence)) {
                frequency[numOccurence] = new List<int> { num };
            }
            else {
                frequency[numOccurence].Add(num);
            }
        }

        int counter = 0;
        foreach(var kvp in frequency.OrderByDescending(x => x.Key)) {
            foreach (int val in kvp.Value) {
                if (counter == k) {
                    return result;
                }

                result[counter] = val;
                counter++;
            }
        }
        return result;
    }
}