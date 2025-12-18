using System;
using System.Collections.Generic;

public class TwoSum
{
    public int[] TwoSumMethod(int[] nums, int target)
    {
        int n = nums.Length;
        Dictionary<int, int> mp = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int rem = target - nums[i];
            if (mp.ContainsKey(rem))
            {
                return new int[] { mp[rem], i };
            }
            mp[nums[i]] = i;
        }

        return new int[] { };
    }
}