# Intuition
I'm new to C# and I'm certain this is **not the most effecient** way of doing this but my first thoughts were to loop through the **nums[]** array and have an if statement that checks whether the sum of the "**firstIndex**" and "**lastIndex**" is equal to the **target**.

Looking forward to any advice on how I can improve this solution and what I should study before attempting similar solutions. 

# Approach
At first, I started out with a single **for loop** followed by an **if statement**. This approach worked as long as the values i.e "**nums[i]** + **nums[i + 1]**" we're being added consecutively.

I therefore added one more loop to retrieve the "**lastIndex**" rather than solely relying on conditional statements. This in combination with the updated **if statement** enables the retreival of the correct indices of the values that add up to the target.

# Complexity
- Time complexity:
O(n2)

- Space complexity:
O(1)

# Code
```csharp
public class Solution {

    public static int[] indices = new int[0];
    public static int firstIndex;
    public static int lastIndex;

    public int[] TwoSum(int[] nums, int target) {

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

        indices = new int[] {firstIndex, lastIndex};
        return indices;
    }
}
```