namespace leetcode{
public class AddTwoNumbers{
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        string list1 = "";
        string list2 = "";
        ListNode retList = new ListNode();
        string ret = "";
        while(l1.next!=null){list1 += l1.val.ToString();}
        while(l2.next!=null){list2 += l2.val.ToString();}
        ret = (Int32.Parse(list1)+Int32.Parse(list2)).ToString();
        for(int i = 0; i<ret.Length; i++){
            retList.val=ret[i];
        }
        return retList;
    }
}
}

