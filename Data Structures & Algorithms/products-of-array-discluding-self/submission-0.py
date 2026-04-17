class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        ltr: List[int] = nums[:] * 1
        rtl: List[int] = nums[:] * 1
        for i in range(len(nums)):
            if i == 0: continue;
            ltr[i] = nums[i]*ltr[i-1]
        print(ltr)
        print(nums)
        for j in range(len(nums)+1):
            if j < 2 or j > len(nums): continue;
            rtl[-j] = nums[-j]*rtl[-j+1]
        print(rtl)

        out = [0] * len(nums)

        for k in range(len(nums)):
            if k - 1 < 0: out[k] = rtl[k+1]
            elif k + 1 == len(nums): out[k] = ltr[k-1]
            else: out[k] = rtl[k+1]*ltr[k-1]

        return out 