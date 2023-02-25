namespace leetcode{
    public class FindMedianSortedArrays {
     public static double findMedianSortedArrays(int[] nums1, int[] nums2) {
        double median = 0.0;
        int[] nums3 = new int[nums1.Length + nums2.Length];

        nums3 = nums1.Concat(nums2).ToArray();
        Array.Sort(nums3);
       
        int mid = ((nums3.Length)/2);
        if(!(nums3.Length%2==0)){
            median = nums3[mid];
        }else{

            median = (double)(nums3[mid]+nums3[mid-1])/2;
        }
        Console.WriteLine("Median: " + median);
        return median;
    }
}}