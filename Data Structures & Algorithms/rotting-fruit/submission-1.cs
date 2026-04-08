public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<int[]> queue = new Queue<int[]>();
        int time = 0;
        int fresh = 0;

        int numRows = grid.Length;
        int numCols = grid[0].Length;

        for(int i = 0; i < numRows; i++) {
            for(int j = 0; j < numCols; j++) {
                if (grid[i][j] == 1) {
                    fresh++;
                }
                if (grid[i][j] == 2) {
                    queue.Enqueue(new int[] {i, j});
                }
            }
        }

        List<int[]> directions = new List<int[]>() {
            new int[] {0, -1},
            new int[] {0, 1},
            new int[] {-1, 0},
            new int[] {1, 0},
        };

        while (queue.Count > 0 && fresh > 0) {
            int length = queue.Count;
            for(int k = 0; k < length; k++) {
                int[] rotten = queue.Dequeue();
                foreach (int[] direction in directions) {
                    int newRow = rotten[0] + direction[0];
                    int newCol = rotten[1] + direction[1];

                    if ((newRow < 0 || newRow == numRows) ||
                        (newCol < 0 || newCol == numCols) ||
                        grid[newRow][newCol] != 1) {
                            continue;
                    }

                    grid[newRow][newCol] = 2;
                    queue.Enqueue(new int[] {newRow, newCol});
                    fresh--;
                }
            }
            time++;
        }

        return fresh == 0 ? time : -1;
    }
}
