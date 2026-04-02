public class KthLargest {
    private PriorityQueue<int, int> maxHeap;
    private int k;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
        foreach (int num in nums) {
            this.maxHeap.Enqueue(num, num);
        }
    }
    
    public int Add(int val) {
        this.maxHeap.Enqueue(val, val);
        List<int> largestValues = new List<int>();
        for (int i = 0; i < k - 1; i++) {
            largestValues.Add(this.maxHeap.Peek());
            this.maxHeap.Dequeue();
        }
        int kth = this.maxHeap.Peek();
        foreach(int value in largestValues) {
            this.maxHeap.Enqueue(value, value);
        }
        return kth;
    }
}
