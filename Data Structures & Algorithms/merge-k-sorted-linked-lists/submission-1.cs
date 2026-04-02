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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> mergedList = new PriorityQueue<ListNode, int>();

        foreach(ListNode list in lists) {
            mergedList.Enqueue(list, list.val);
        }

        ListNode dummy = new ListNode(-1);
        ListNode curr = dummy;
        while(mergedList.Count > 0) {
            ListNode smallest = mergedList.Dequeue();
            curr.next = smallest;
            curr = curr.next;
            if (smallest.next != null) {
                mergedList.Enqueue(smallest.next, smallest.next.val);
            }
        }

        return dummy.next;
    }
}
