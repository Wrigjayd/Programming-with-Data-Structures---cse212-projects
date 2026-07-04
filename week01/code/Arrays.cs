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

        //incase the lengthis 0
        if (length <= 0)
        {
            return new double[0];
        }
        // create a new array to store the multiples, the size will match the lenght of lenght. this will store the multiples
        double[] result = new double[length];

        //loop for length
        for (int i = 0; i < length; i++)
        {
            //for each iteration multiply the starting number by the current iteration + 1, due to arrays starting at 0, and save the multiple. 
            result[i] = number * (i + 1); 
        }

        return result; // return the result
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

        // for code where the data size is too small or not there at all
        // if data is null or less then 1 return
        if (data == null || data.Count <= 1)
        {
            return;
        }

        //handle lists and rotations that are the same number ie the data size is 10 and the rotation amount is 10 it would be the same list
        if (amount == data.Count)
        {
            return;
        }

        // now for actual code that would have a change
        // I will be splitting the list into two and putting them back together.
        // take the data and minus the amount for where i will split the list

        int splitIndex = data.Count - amount;

        // take the data array into two at the splitindex.
        //left side of the original data array
        List<int> leftHalf = data.GetRange(0, splitIndex);
        //right half of the data
        List<int> rightHalf = data.GetRange(splitIndex, amount);

        //then we will clear the original array
        data.Clear();

        //then rearrange the data starting with the right half then the left half
        data.AddRange(rightHalf);
        //now the left
        data.AddRange(leftHalf);
    }
}
