using leetcode;
public class SplitLinkedListToParts {
    public ListNode[] SplitListToParts(ListNode head, int k) {
        ListNode? current = head;
        int n = 0;
        //didn't like that we needed to traverse the nodes to find the length, but oh well.
        while (current!=null){
            n++;
            current = current.next;
        }

        ListNode[] nodes = new ListNode[k];
        int rest = n%k;
        current = head;
        for(int i = 0; i<k; i++){
            nodes[i] = current;
            for(int j = 0; j<n/k+(rest > 0 ? 1 : 0) -1; j++)
            {
                if(current!=null) current = current.next;
            }
            if(current!=null){
                ListNode temp = current;
                current = current.next;
                temp.next = null;
                rest--;
            }

        }
        return nodes;

        //int rest = listelengde%k
        //while neste != null
        //      split, men legg til en ekstra så lenge rest ikke er 0
        //      rest--
        //      
        //previous.next = null;
    }
}