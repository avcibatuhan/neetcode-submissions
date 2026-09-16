class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        left = 0
        window = set()
        maxSize = 0

        for right in range(len(s)):
            while s[right] in window:
                window.discard(s[left])
                left += 1
            window.add(s[right])
            maxSize = max(maxSize, len(window))

        return maxSize