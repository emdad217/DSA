using System.Numerics;

namespace DSA.ArrayProblems;

public  class PlusOneArray
{
    public int[] GetPlusOne(int[] digits)
    {
        

        BigInteger number = new();

        foreach (var digit in digits)
        {
            number = number * 10 + digit; // Shift left and add the current digit
        }

        BigInteger resultNumber = number + 1;
        //BigInteger countResultNumber = resultNumber;

        //int count = 0;
        //while (countResultNumber > 0)
        //{
        //    countResultNumber /= 10;
        //    count++;
        //}


        //int[] results = new int[count];
        //int index = results.Length - 1;
        //while (resultNumber > 0)
        //{
        //    results[index] = (int)(resultNumber % 10);
        //    resultNumber /= 10;
        //    index--;
        //}

        //Convert the resulting BigInteger back into an array of digits
        string resultString = resultNumber.ToString();
        int[] results = new int[resultString.Length];
        for (int i = 0; i < resultString.Length; i++)
        {
            results[i] = resultString[i] - '0'; // Convert char to int
        }

        return results;

    }

    public BigInteger GettheSameArray(int[] digits)
    {


        BigInteger number = 0;

        foreach (var digit in digits)
        {
            number = number * 10 + digit; // Shift left and add the current digit
        }

        var a = number.ToByteArray();

        return number + 1;
    }
}