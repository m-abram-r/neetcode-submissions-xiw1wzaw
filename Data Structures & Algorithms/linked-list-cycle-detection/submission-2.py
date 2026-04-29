# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        if head is None or head.next is None:
            return False
        
        slow = fast = head

        while True:
            slow = slow.next
            for _ in range(2):
                fast = fast.next
                if fast is None:
                    break
            if fast is slow:
                return True
            if fast is None:
                break

        return False
