public class MedianFinder {
    private PriorityQueue<int, int> minHeap;
    private PriorityQueue<int, int> maxHeap;

    public MedianFinder() {
        this.minHeap = new PriorityQueue<int, int>();
        this.maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));    
    }
    
    public void AddNum(int num) {
        if(maxHeap.Count != 0 && num < maxHeap.Peek()) {
            maxHeap.Enqueue(num, num);
        }
        else {
            minHeap.Enqueue(num, num);
        }

        if (maxHeap.Count > minHeap.Count + 1) {
            int smallest = maxHeap.Dequeue();
            minHeap.Enqueue(smallest, smallest);
        }
        else if (minHeap.Count > maxHeap.Count + 1) {
            int largest = minHeap.Dequeue();
            maxHeap.Enqueue(largest, largest);
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
            return ((double)(maxHeap.Peek() + minHeap.Peek()) / 2.0);
        }
    }
}
