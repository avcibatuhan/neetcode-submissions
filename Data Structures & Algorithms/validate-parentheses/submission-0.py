class Solution:
    def isValid(self, s: str) -> bool:
        
        stack = []
        pairs = {')' : '(', '}':'{',']': '['}

        for i,c in enumerate(s):
            if c in pairs.values():
                stack.append(c)
            else:
                if len(stack) == 0:
                    return False
                elif pairs[c] != stack[-1]:
                    return False
                stack.pop()
        
        return len(stack) == 0
            
            