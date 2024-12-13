namespace DSA.ArrayProblems
{
    public class FindDifferenceArray
    {
        public int[] GetFindDifferenceArray(int[] nums)
        {
            int n = nums.Length;
            int[] differenceArray = new int[n];
            // TODO: Write your code here

            for (int i = 0; i < n; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += nums[j];
                }

                for (int k = i + 1; k < n; k++)
                {
                    rightSum += nums[k];
                }

                differenceArray[i] = (leftSum - rightSum) < 0 ? (leftSum - rightSum) * -1 : (leftSum - rightSum);
            }

            return differenceArray;
        }
    }
}
