public class Solution {
    public bool hasDuplicate(int[] nums) {

        var myNewHashSet = new HashSet<int>();

        for(int i=0; i< nums.Count(); i++){
            if(myNewHashSet.Contains(nums[i])){
                return true;
            }

            myNewHashSet.Add(nums[i]);
        }

        return false;
    }
}