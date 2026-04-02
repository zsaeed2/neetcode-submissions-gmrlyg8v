class Solution {
    public boolean checkInclusion(String s1, String s2) {
        int length = s1.length();
        Map<Character, Integer> map1 = new HashMap<Character, Integer>();

        for (char s : s1.toCharArray()) {
            if (map1.containsKey(s)) {
                map1.put(s, map1.get(s) + 1);
            }
            else {
                map1.put(s, 1);
            }
        }

        for(int i = 0; i < s2.length() - length + 1; i++) {
            String window = s2.substring(i, i + length);
            Map<Character, Integer> map2 = new HashMap<Character, Integer>();
            for (char s : window.toCharArray()) {
                if (map2.containsKey(s)) {
                    map2.put(s, map2.get(s) + 1);
                }
                else {
                    map2.put(s, 1);
                }
            }
            if (map1.equals(map2)) {
                return true;
            }
        }

        return false;
    }
}
