public class MedianFinder {
    private PriorityQueue<int, int> minHeap;
    private PriorityQueue<int, int> maxHeap;
    public MedianFinder() {
        this.minHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        this.maxHeap = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        if (maxHeap.Count > 0 && num > maxHeap.Peek()) {
            maxHeap.Enqueue(num, num);
        }
        else {
            minHeap.Enqueue(num, num);
        }

        if (maxHeap.Count > minHeap.Count + 1) {
            int maxMove = maxHeap.Dequeue();
            minHeap.Enqueue(maxMove, maxMove);
        }

        if (minHeap.Count > maxHeap.Count + 1) {
            int minMove = minHeap.Dequeue();
            maxHeap.Enqueue(minMove, minMove);
        }
        
    }
    
    public double FindMedian() {
        if (minHeap.Count > maxHeap.Count) {
            return minHeap.Peek();
        }
        else if (maxHeap.Count > minHeap.Count) {
            return maxHeap.Peek();
        }
        else {
            return (minHeap.Peek() + maxHeap.Peek()) / 2.0;
        }
    }
}
