namespace Algorithm_Practice;

public class Big_O
{
    //Big-O of this function is O(1) because the number of steps do not increase regardless of the input
    /// <summary>
    /// A function to check if a year is a leap year or not
    /// </summary>
    /// <param name="year"></param>
    /// <returns>True if leap year, false if not</returns>
    public bool isLeapYear(int year)
    { 
        return (year % 100 == 0) 
            ? (year % 400 == 0) : 
            (year % 4 == 0 );
    }
    
    //Big-O of this function is O(N) because the number of steps increase as the size of input increases
    /// <summary>
    /// A function to calculate the sum of elements in an array
    /// </summary>
    /// <param name="array"></param>
    /// <returns>the total sum of array</returns>
    public int arraySum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i< array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    //Big-O or time complexity of this function is O(Log N) because 
    /// <summary>
    /// A function to get the sqaure needed to place the grains
    /// </summary>
    /// <param name="N_grain"></param>
    /// <returns>The number of the sqaure </returns>
    public int chessBoardSpace(int N_grain)
    {
        int chessBoardSpaces = 1;
        int placedGrains = 1;

        while (placedGrains < N_grain)
        {
            placedGrains *= 2;
            chessBoardSpaces++;
        }
        return chessBoardSpaces;
    }

    // The time complexity of this function is O(N2)
    /// <summary>
    /// A function that returns an array containg strings starting with a
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public List<string> SelectAStrings(List<string> array)
    {
        List<string> newArray = new List<string>();

        foreach (var str in array)
        {
            if (str.StartsWith("a"))
            {
                newArray.Add(str);  
            }
        }
        return newArray;
    }
    
    // Big-O of this function is O(log N) because no matter the input size the number of steps stays the same
    /// <summary>
    /// A function to calculate the median of numbers in an array
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public double median(int[] array)
    {
        Array.Sort(array);
        int middle = array.Length / 2;

        if (array.Length % 2 == 0)
        {
            return (array[middle - 1] + array[middle]) / 2;
        }
        else
        {
            return array[middle];
        }
    }
}