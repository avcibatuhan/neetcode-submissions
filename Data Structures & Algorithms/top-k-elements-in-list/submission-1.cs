public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var counts = new Dictionary<int, int>();
        foreach (int num in nums)
            counts[num] = counts.GetValueOrDefault(num) + 1;

        var buckets = new List<int>[nums.Length + 1];
        foreach (var kvp in counts)
        {
            int freq = kvp.Value;
            if (buckets[freq] == null)
                buckets[freq] = new List<int>();
            buckets[freq].Add(kvp.Key);
        }

        var result = new List<int>();
        for (int freq = buckets.Length - 1; freq >= 1; freq--)
        {
            if (buckets[freq] == null) continue;

            foreach (int num in buckets[freq])
            {
                result.Add(num);
                if (result.Count == k) return result.ToArray();
            }
        }

        return result.ToArray();
    }
}
