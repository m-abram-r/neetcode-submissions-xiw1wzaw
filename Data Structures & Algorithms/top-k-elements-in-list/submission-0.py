class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        res = []
        count = {}
        for i in nums:
            if not i in count:
                count[i] = 1
            else:
                count[i] += 1
        return [x[0] for x in sorted(count.items(), key=lambda x: x[1], reverse=True)[:k]]