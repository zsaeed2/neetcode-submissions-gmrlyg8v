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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();
        if (list1 != null) {
            minHeap.Enqueue(list1, list1.val);
        }
        if (list2 != null) {
            minHeap.Enqueue(list2, list2.val);
        }

        ListNode result = new ListNode(-1);
        ListNode temp = result;
        while(minHeap.Count > 0) {
            ListNode lowest = minHeap.Dequeue();
            temp.next = lowest;
            temp = temp.next;
            if (lowest.next != null) {
                minHeap.Enqueue(lowest.next, lowest.next.val);
            }
        }

        return result.next;
    }
}