namespace Solution.Utilities;
public class _Solution
{
    public static int[] indices;
    public static int firstIndex;
    public static int lastIndex;

    public void FindTarget(int[] nums, int target)
    {
        indices = new int[0];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + (nums[j]) == target)
                {
                    firstIndex = i;
                    lastIndex = j;
                    break;
                }
            }
        }

        indices = new int[] { firstIndex, lastIndex };

        foreach (var index in indices)
        {
            Console.WriteLine(index);
        }
    }
}
