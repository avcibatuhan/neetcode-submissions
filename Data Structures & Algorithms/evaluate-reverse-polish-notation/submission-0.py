class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        
        stackWillBeCalculated = []
        operators = ["+", "-", "/", "*"]

        for i in range(len(tokens)):
            if tokens[i] in operators:
                b = stackWillBeCalculated.pop()
                a = stackWillBeCalculated.pop()

                result = 0
                if tokens[i] == "+":
                    result = a+b
                elif tokens[i] == "-":
                    result = a-b
                elif tokens[i] == "*":
                    result = a*b
                elif tokens[i] == "/":
                    result = int(a/b)

                stackWillBeCalculated.append(result)
                
            else:
                stackWillBeCalculated.append(int(tokens[i]))
        
        return stackWillBeCalculated[0]