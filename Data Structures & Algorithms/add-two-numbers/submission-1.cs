/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carryOver = 0;
        ListNode ans = new ListNode(-1);
        ListNode curr = ans;
        while (l1 != null || l2 != null || carryOver > 0) {
            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;
            int sum = (val1 + val2 + carryOver);
            carryOver = sum/10;
            sum = sum % 10;
            curr.next = new ListNode(sum);
            curr = curr.next;
            l1 = l1==null ? null : l1.next;
            l2 = l2==null ? null : l2.next;
        }

        return ans.next;
    }
}
