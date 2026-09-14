class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        
        # for i,n in enumerate(numbers):
        left = 0
        right = len(numbers) - 1

        while left < right:
            total = numbers[left] + numbers[right]
            if total < target:
                left +=1
            elif total > target:
                right -=1
            else:
                return [left + 1, right + 1]