namespace DSA.ArrayProblems;

public class RunningSumArray
{
    public int[] GettingRunningSumArray(int[] nums)
    {
        int[] runningSums = new int[nums.Length];

        if (nums.Length == 0) return [];

        //O(n)
        for (int i = 0; i < nums.Length; i++)
        {
            int runningSum = 0;

            //O(n)
            for (int j = 0; j <= i; j++)
            {
                runningSum += nums[j];
            }
            runningSums[i] = runningSum;
        }

        //Time complexity: O(n2)

        return runningSums;
    }
}