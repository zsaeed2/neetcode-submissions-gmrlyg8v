public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<int[]> rotten = new Queue<int[]>();
        int fresh = 0;
        int time = 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    fresh++;
                }
                if (grid[i][j] == 2) {
                    rotten.Enqueue(new int[] {i,j});
                }
            }
        }

        List<int[]> directions = new List<int[]>() {
            new int[] {-1, 0},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {0, 1}
        };

        while (rotten.Count > 0 && fresh > 0) {
            int numRotten = rotten.Count;
            for (int i = 0; i < numRotten; i++) {
                int[] currentRotten = rotten.Dequeue();
                foreach (int[] direction in directions) {
                    int newRow = currentRotten[0] + direction[0];
                    int newCol = currentRotten[1] + direction[1];
                    if ((newRow < 0 || newRow >= rows) ||
                        (newCol < 0 || newCol >= cols) ||
                        grid[newRow][newCol] != 1) {
                            continue;
                    }
                    grid[newRow][newCol] = 2;
                    rotten.Enqueue(new int[] {newRow, newCol});
                    fresh--;
                }
            }
            time++;
        }

        return fresh > 0 ? -1 : time;
    }
}
