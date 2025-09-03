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
        // step 1: make an array with size = length
        // step 2: loop from 0 up to length-1
        // step 3: at each index, put number * (i+1)
        // step 4: return the array

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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
        // step 1: if list is empty or only 1 item, do nothing
        // step 2: make sure amount isn’t bigger than list size (use %)
        // step 3: take the last "amount" numbers
        // step 4: remove them from the end
        // step 5: stick them in front
        // step 6: done

        if (data == null || data.Count <= 1)
        {
            return;
        }

        amount = amount % data.Count;

        if (amount == 0)
        {
            return;
        }

        int startIndex = data.Count - amount;
        List<int> tail = data.GetRange(startIndex, amount);
        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, tail);
    }
}
