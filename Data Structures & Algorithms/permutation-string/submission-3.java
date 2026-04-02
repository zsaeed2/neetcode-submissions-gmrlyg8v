class Solution {
    public boolean checkInclusion(String s1, String s2) {
        int length = s1.length();
        Map<Character, Integer> map1 = new HashMap<Character, Integer>();

        for (char s : s1.toCharArray()) {
            map1.put(s, map1.getOrDefault(s, 0) + 1);
        }

        for(int i = 0; i < s2.length() - length + 1; i++) {
            Map<Character, Integer> map2 = new HashMap<Character, Integer>();
            
            for (char s : s2.substring(i, i + length).toCharArray()) {
                map2.put(s, map2.getOrDefault(s, 0) + 1);
            }

            if (map1.equals(map2)) {
                return true;
            }
        }

        return false;
    }
}
