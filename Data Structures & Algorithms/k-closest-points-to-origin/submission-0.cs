public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> closestToOrigin = new PriorityQueue<int[], double>();
        foreach (int[] point in points) {
            closestToOrigin.Enqueue(point, this.DistanceFromOrigin(point));
        }

        int[][] closestPoints = new int[k][];

        for(int i = 0; i < k; i++) {
            closestPoints[i] = closestToOrigin.Dequeue();
        }

        return closestPoints;        
    }

    private double DistanceFromOrigin(int[] point) {
        return Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
    }
}
