public class Solution {
    public bool IsPalindrome(string s) {
        var sb = new StringBuilder();

        foreach (char c in s) {
            if(char.IsLetterOrDigit(c)){
                sb.Append(char.ToLower(c));
            }
        }

        string clean = sb.ToString();

        for (int i = 0; i < clean.Length / 2; i++) {
            var fromBeginning = clean[i];
            var fromEnd = clean[clean.Length - i - 1];

            if(fromBeginning != fromEnd) return false;
        }

        return true;
    }
}
