public class Solution {

    public string Encode(IList<string> strs) {
        
        var sb = new StringBuilder();

        foreach (var str in strs) {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int hashIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, hashIndex - i));

            result.Add(s.Substring(hashIndex + 1, length));

            i = hashIndex + 1 + length;
        }

        return result;
    }
}
