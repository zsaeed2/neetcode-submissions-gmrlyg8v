public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> largestNums = new PriorityQueue<int, int>();

        foreach (int num in nums) {
            largestNums.Enqueue(num, num);
            if (largestNums.Count > k) {
                largestNums.Dequeue();
            }
        }

        return largestNums.Peek();
    }
}
