namespace DSA.ArrayProblems;

public class FindMaximumAltitudeArray
{
    public int GetLargestAltitude(int[] gain)
    {
        int maxAltitude = 0;
        int runningSum = gain[0];

        if (maxAltitude < runningSum) maxAltitude = runningSum;

        //Time: O(n)
        //Space: O(1)
        for (int i = 1; i < gain.Length; i++)
        {
            runningSum += gain[i];
            if(maxAltitude < runningSum) maxAltitude = runningSum;
        }

        // TODO: Write your code here
        return maxAltitude;
    }
}