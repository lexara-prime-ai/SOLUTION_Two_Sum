// using Solution.Utilities;

// _Solution solution = new _Solution();
// int[] nums = new int[]{ 2, 7, 11, 15 };
// solution.FindTarget(nums, 9);

public class Soln
{
    public static int[] indices = new int[0];
    public static int firstIndex;
    public static int lastIndex;

    static void Main()
    {
        Soln sln = new Soln();
        sln.TwoSum(new int[] { 2, 7, 11, 15 }, 13);

        foreach (var index in indices)
        {
            Console.WriteLine(index);
        }
    }

    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    firstIndex = i;
                    lastIndex = j;
                    break;
                }
            }
        }

        indices = new int[] { firstIndex, lastIndex };
        return indices;
    }
}
