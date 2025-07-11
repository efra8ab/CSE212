using System.Runtime.InteropServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Add our dynamic array
        List<double> multiples = new List<double>();

        //A for loop will help us to add each multiple to our array

        for (int i = 1; i <= length; i++)
        {
            multiples.Add(number * i);
        }

        //lastly we convert to a static array as indicated by the function output
        return multiples.ToArray(); // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //flipping the list 
        Reverse(data, 0, data.Count - 1);
        //flipping the first values (previously the last ones)
        Reverse(data, 0, amount - 1);
        //flipping the rest of the values
        Reverse(data, amount, data.Count - 1);

    }

    public static void Reverse(List<int> list, int start, int end)
    {
        //keep it open while our start is less than our last value 
        while (start < end)
        {
            int temp = list[start]; //saving the value of the starting index in temp for later
            list[start] = list[end]; // we assign the Start place the last value (from our last place)
            list[end] = temp; // we now assign to the last position the first value we saved on temp
            start++; //increase the start place by 1 until we reach the middle
            end--; // decrease the last place by 1 until we reach the middle
        }
    }
}
