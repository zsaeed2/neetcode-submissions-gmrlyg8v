public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char task in tasks) {
            if (frequency.ContainsKey(task)) {
                frequency[task]++;
            }
            else {
                frequency[task] = 1;
            }
        }

        int maxFrequency = frequency.Values.Max();
        int maxCount = frequency.Values.Where(x => x == maxFrequency).Count();


        return Math.Max((maxFrequency - 1) * (n + 1) + maxCount, tasks.Length);

    }
}
