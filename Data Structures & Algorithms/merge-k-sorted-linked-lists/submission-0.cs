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
        var minHeap = new PriorityQueue<ListNode, int>();
        foreach (ListNode list in lists) {
            if (list != null) {
                minHeap.Enqueue(list, list.val);
            }
        }

        ListNode sortedList = new ListNode(-1);
        ListNode curNode = sortedList;
        while (minHeap.Count > 0) {
            ListNode node = minHeap.Dequeue();
            curNode.next = node;
            curNode = curNode.next;

            node = node.next;
            if (node != null) {
                minHeap.Enqueue(node, node.val);
            }
        }

        return sortedList.next;
    }
}
