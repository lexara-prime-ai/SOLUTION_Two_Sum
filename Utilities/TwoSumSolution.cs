using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.Utilities;
public class _Solution
{
    public static int[] indices;
    public static int firstIndex;
    public static int lastIndex;

    public void FindTarget(int[] nums, int target)
    {
        indices = new int[0];

        int arrayLength = nums.Length;

        for (int i = 0; i < arrayLength; i++)
        {
            if (nums[i] + (nums[i + 1]) == target)
            {
                firstIndex = nums[i];
                lastIndex = nums[i + 1];
                break;
            }
        }



        indices = new int[] { firstIndex, lastIndex };

        foreach (var index in indices)
        {
            Console.WriteLine(index);
        }
    }
}
