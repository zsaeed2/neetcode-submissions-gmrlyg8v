public class KthLargest {
    private PriorityQueue<int, int> maxHeap;
    private int k;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.maxHeap = new PriorityQueue<int, int>();
        foreach (int num in nums) {
            this.maxHeap.Enqueue(num, num);
            if (this.maxHeap.Count > k) {
                this.maxHeap.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        this.maxHeap.Enqueue(val, val);
        if (this.maxHeap.Count > k) {
            this.maxHeap.Dequeue();
        }
        return this.maxHeap.Peek();
    }
}
