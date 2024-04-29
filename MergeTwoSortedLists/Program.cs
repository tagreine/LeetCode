// ReSharper disable All

using System.Diagnostics;

namespace LeetCode;

class Program
{
    static void Main(string[] args)
    {
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        
        ListNode list2 = new ListNode(1);

        ListNode merged = Solution.MergeTwoLists(list1, list2);
        
        ListNode.DisplayMerged(merged);
        
    }
    
    public class Solution
    {

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null && list2 is null)
                return null!;
            
            if ((list1 is null)||(list2 is not null && list1.val >= list2.val)) {
                ListNode t = list1!; 
                list1 = list2; 
                list2 = t;
            }
            if (list1 is not null)
            {
                list1.next = MergeTwoLists(list1.next, list2!);
            }
            return list1!;
        }
    }
    
    public sealed class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null!) {
            this.val = val;
            this.next = next;
        }
        
        public static void DisplayMerged(ListNode listNode)
        {   
            
            while (listNode is not null)
            {
                Console.WriteLine(listNode.val);
                listNode = listNode.next;
            }
        }
    }
    

}