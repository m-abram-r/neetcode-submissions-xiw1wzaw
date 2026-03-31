class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        resd = {}
        for s in strs:
            ag = {}
            for c in s:
                if not c in ag: ag[c] = 1
                else: ag[c] += 1
            ags = tuple(sorted(ag.items()))
            if ags not in resd: resd[ags] = []
            resd[ags].append(s)
        res = []
        for l in resd.values():
            res.append(l)
        return res
        