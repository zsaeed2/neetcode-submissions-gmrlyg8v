public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> smasher = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (int stone in stones) {
            smasher.Enqueue(stone, stone);
        }

        while (smasher.Count > 1) {
            int smashedStone = Math.Abs(smasher.Dequeue() - smasher.Dequeue());
            smasher.Enqueue(smashedStone, smashedStone);
        }
        return smasher.Peek();
    }
}
