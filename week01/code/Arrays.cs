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
        // a função suporta numeros inteiros, decimais e negativos.
         // step 1: Create the array to store the multiple
        double[] multiples = new double[length];

        // step 2: use a loop to calculate the multiples
        for (int i = 0; i < length; i++)
        {
            // the multiple is calculated as 'number' * (i+1)
            multiples[i] = number * (i + 1);
        }

        // step 3: return the multiplies array
        return multiples;
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

        //step 1: get the initial part of the list, which will be presented at the end of the list in the future
        List<int> dataA = data.GetRange(0, data.Count - amount);
        //step 2: the final part of the list that will be moved to the beginning
        List<int> dataB = data.GetRange(data.Count - amount, amount);
        //step 3: rearrange the data so that dataA is last and dataB is first
        data.Clear(); //clean the list
        //add the dataB part to the beginning
        data.AddRange(dataB);
        //add the dataA part to the end
        data.AddRange(dataA);
    }
}
//There are multiple ways to solve this problem.
//Outros métodos que você pode achar úteis são:
//RemoveRange(index, count)
//InsertRange(index, list or array)
//Add(value)
//Insert(index, value)
//RemoveAt(index)