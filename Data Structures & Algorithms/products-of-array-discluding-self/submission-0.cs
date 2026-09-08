public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var output = new int[n];

        // Pass 1: left products
        int prefix = 1;
        for (int i = 0; i < n; i++)
        {
            output[i] = prefix;
            prefix *= nums[i];
        }

        // Pass 2: multiply in right products
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            output[i] *= suffix;
            suffix *= nums[i];
        }

        return output;
    }
}
