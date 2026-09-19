class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        stack = []
        returnArray = [0] * len(temperatures)

        for i,temp in enumerate(temperatures):
            while len(stack) > 0 and temp > temperatures[stack[-1]]:
                j = stack.pop()
                returnArray[j] = i - j
            stack.append(i)

        return returnArray