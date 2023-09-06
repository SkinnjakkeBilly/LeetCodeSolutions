namespace leetcode{
    public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode currentNode = head;
        HashSet<ListNode> visited = new HashSet<ListNode>();

        while(currentNode != null){
            if(visited.Contains(currentNode)){
                return true;
            }else{
                visited.Add(currentNode);
                currentNode = currentNode.next;
            }
        }
        return false;
    }
}
}