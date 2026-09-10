class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        newDict = {}

        for i in nums:
            if newDict.get(i) == None:
                newDict[i] = 1
            else:
                return True
        
        return False