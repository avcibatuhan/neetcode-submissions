public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var seen = new Dictionary<int,int>();
        
        // target =  
        for(int i = 0; i< nums.Length; i++){
            var difference = target - nums[i];

            if(seen.TryGetValue(difference, out int j)){
                return new int[]{j,i};
            }

            seen[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
