namespace leetcode{
public class BinarySearch {
    public int search(int[] nums, int target) {
        //Utkommentert er den nice måten, men siden dette er for å lære vil jeg skrive metoden fra bunnen.
        //int index = Array.BinarySearch(nums, target);
        /*if(index<0){
            index = -1;
        }*/

        int index = -1;
        int left = 0; 
        int right = nums.Length-1;
        int mid = 0; 
        while(left<right){
            mid = (left+right)/2;
            if(nums[mid]<target){
                left = mid+1;
            }else if(nums[mid]>target){
                right = mid-1;
            }else{
                return mid;
            }
        }
        return index;
    }
}
}
