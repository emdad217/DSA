namespace DSA.ArrayProblems;

public class CheckDuplicateArray
{
    public bool IsDuplicateArray(int[] nums)
    {
        //O(n)
        for (int i = 0; i < nums.Length; i++)
        {
            //O(n)
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])  return true;
            }
        }

        //Total complexity: O(n2)
        return false;
    }
}