namespace DSA.ArrayProblems;

public class FindDifferenceArray
{
    public int[] GetFindDifferenceArray(int[] nums)
    {
        int n = nums.Length;
        int[] differenceArray = new int[n];
        // TODO: Write your code here

        //Outer loop: O(n)
        for (int i = 0; i < n; i++)
        {
            int leftSum = 0;
            int rightSum = 0;
            //O(n)
            for (int j = i - 1; j >= 0; j--)
            {
                leftSum += nums[j];
            }

            //O(n)
            for (int k = i + 1; k < n; k++)
            {
                rightSum += nums[k];
            }

            //Inner loop: O(n) + O(n) = O(2n) = 2*O(n) = O(n)

            differenceArray[i] = (leftSum - rightSum) < 0 ? (leftSum - rightSum) * -1 : (leftSum - rightSum);
        }

        //Total: O(n*n) = O(n^2)

        return differenceArray;
    }
}