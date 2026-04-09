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
        PriorityQueue<ListNode, int> merger = new PriorityQueue<ListNode, int>();

        foreach (ListNode list in lists) {
            merger.Enqueue(list, list.val);
        }

        ListNode result = new ListNode(-1);
        ListNode curr = result;

        while (merger.Count > 0) {
            ListNode temp = merger.Dequeue();
            curr.next = temp;
            curr = curr.next;

            temp = temp.next;
            if(temp != null) {
                merger.Enqueue(temp, temp.val);
            }
        }

        return result.next;
    }
}
