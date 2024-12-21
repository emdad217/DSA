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

        //Total complexity: O(n^2)
        return false;
    }


    //should all elements within the array length;
    //Time complexity: O(n)
    public bool IsDuplicateArrayOn(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1; // Use the value as an index (adjusted for 0-based indexing)

            if (nums[index] < 0)
            {
                return true; // Found a duplicate
            }

            nums[index] = -nums[index]; // Mark as visited
        }

        return false; // No duplicate found
    }
}