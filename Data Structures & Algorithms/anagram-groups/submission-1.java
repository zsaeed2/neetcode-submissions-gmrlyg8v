class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        Map<String, List<String>> anagrams = new HashMap<>();

        for (String str : strs) {
            char[] keyArray = str.toCharArray();
            Arrays.sort(keyArray);
            String key = new String(keyArray);
            if (anagrams.containsKey(key)) {
                anagrams.get(key).add(str);
            }
            else {
                List<String> anagram = new ArrayList<String>();
                anagram.add(str);
                anagrams.put(key, anagram);
            }
        }
        return new ArrayList<List<String>>(anagrams.values());
    }
}
