public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char task in tasks) {
            if (!frequencies.ContainsKey(task)) {
                frequencies[task] = 1;
            }
            else {
                frequencies[task]++;
            }
        }

        List<int> frequencyList = frequencies.Values.ToList();

        int maxFrequency = frequencyList.Max();

        frequencyList.Remove(maxFrequency);

        int idleSpaces = (maxFrequency - 1) * n;

        foreach (int frequency in frequencyList) {
            idleSpaces -= Math.Min(maxFrequency - 1, frequency);
        }

        return tasks.Length + Math.Max(0, idleSpaces);
    }
}
