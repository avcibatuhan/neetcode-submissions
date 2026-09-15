class Solution:
    def maxArea(self, heights: List[int]) -> int:
        
        maxSize = 0        

        l,r = 0, len(heights) - 1

        while l < r:
            area = (r - l) * min(heights[r],heights[l])
            maxSize = max(maxSize,area)

            if heights[l] < heights[r]:
                l += 1
            else:
                r -= 1
                    
        
        return maxSize

        