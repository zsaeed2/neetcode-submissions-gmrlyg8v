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
            if (list != null) {
                mergedList.Enqueue(list, list.val);
            }
        }

        ListNode dummy = new ListNode(-1);
        ListNode curr = dummy;
        while (mergedList.Count > 0) {
            ListNode smallest = mergedList.Dequeue();
            curr.next = smallest;
            curr = curr.next;

            smallest = smallest.next;
            if (smallest != null) {
                mergedList.Enqueue(smallest, smallest.val);
            }
        }

        return dummy.next;
    }
}
