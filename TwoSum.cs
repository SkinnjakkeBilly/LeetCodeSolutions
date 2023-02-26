namespace leetcode{
    public class TwoSum 
{
    public int[] twoSum(int[] nums, int target) 
    {
        int[] ret = new int[2];

        for(int i = 0; i<nums.Length; i++)
        {
            for(int j = 0; j<nums.Length; j++)
            {
                if(nums[i]+nums[j]==target && i!=j)
                {
                    ret[0]=i;
                    ret[1]=j;
                    break;
                }
            }
        }

        return ret;
    }
}
}