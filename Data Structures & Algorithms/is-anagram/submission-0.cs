public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s == "" || t == "" || s.Length != t.Length) return false;

        var counts = new Dictionary<char,int>();

        foreach(char c in s){
            counts[c] = counts.TryGetValue(c, out int n) ? n+1 : 0 + 1;
        }

        foreach(char c in t){
            if(!counts.TryGetValue(c, out int n) || n == 0) return false;
            counts[c] = n -1;
        }

        return true;
    }
}
