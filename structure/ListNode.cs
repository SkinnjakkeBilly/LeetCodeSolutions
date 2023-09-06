namespace leetcode.structure;
using System.Collections;


/**
 * Definition for a list node.
 * Stolen from : https://github.com/zhaoguanchen/leetcode/blob/main/src/leetcode/structure/ListNode.java
 */
public class ListNode {

    public int val;

    public ListNode next;


    public ListNode() {
    }

    public ListNode(int val) {
        this.val = val;
    }

    public ListNode(int val, ListNode next) {
        this.val = val;
        this.next = next;
    }


    /**
     * generate by array
     *
     * @param array
     * @return
     */
    public static ListNode ConstructList(int[] array) {
        if (array == null || array.Length == 0 || array[0] == null) {
            return null;
        }

        int length = array.Length;
        ListNode root = new ListNode(array[0]);

        ListNode currentNode = root;
        ListNode newNode;
        for (int i = 1; i < length; i++) {
            newNode = new ListNode(array[i]);
            currentNode.next = newNode;
            currentNode = currentNode.next;
        }
        return root;
    }

    public static void setCycle(ListNode head, Int32 m) {
        if (head == null || head.next == null) {
            return;
        }

        ListNode last = head;

        while (last.next != null) {
            last = last.next;
        }
        ListNode root = head;

        for (int i = 0; i < m; i++) {
            if (root == null) {
                return;
            }
            root = root.next;
        }
        last.next = root;
    }

    /**
     * generate by array
     *
     * @param
     * @return
     */
    public static void print(ListNode listNode) {
        if (listNode == null) {
            Console.WriteLine("node is null");
            return;
        }
        List<Int32> list = new List<Int32>
        {
            listNode.val
        };
        while (listNode.next != null) {

            list.Add(listNode.next.val);
            listNode = listNode.next;
        }

        Console.WriteLine(list.AsEnumerable<Int32>());
    }
}
