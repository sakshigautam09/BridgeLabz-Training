using System;

public class RemoveElement
{
    public int RemoveElementMethod(int[] nums, int val)
    {
        int i = 0;
        int j = nums.Length - 1;
        int ans = 0;

        while (i <= j)
        {
            if (nums[i] != val)
            {
                i++;
                ans++;
            }
            else
            {
                // Swap nums[i] and nums[j]
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j--;
            }
        }

        return ans;
    }
}
