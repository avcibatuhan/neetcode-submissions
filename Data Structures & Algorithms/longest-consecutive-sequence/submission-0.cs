public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = new HashSet<int>();

        for(int i=0; i<nums.Length;i++){
            var currentValue = nums[i];
            hash.Add(nums[i]);
        }

        var sequenceStarterList = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            if(!hash.Contains(nums[i] - 1)){
                sequenceStarterList.Add(nums[i]);
            }
        }       

        int lastLongestConsecutive=0;

        for (int i = 0; i < sequenceStarterList.Count(); i++) {
            var currentValue = sequenceStarterList[i];
            int currentLength = 1;

            while(hash.Contains(currentValue + 1)){
                currentValue += 1;
                currentLength += 1;
            }

            lastLongestConsecutive = Math.Max(lastLongestConsecutive,currentLength);

        }

        return lastLongestConsecutive;
    }
}
