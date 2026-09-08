public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var frequencyDictList = new Dictionary<string,List<string>>();

        foreach (var word in strs) 
        {
            var chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!frequencyDictList.ContainsKey(key))
                frequencyDictList[key] = new List<string>();

            frequencyDictList[key].Add(word);
        }

        return frequencyDictList.Values.ToList();
    }
}