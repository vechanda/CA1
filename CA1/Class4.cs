using System;
using System.Linq;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {

        return sortedArray.ToList<int>().Count(i => i < lessThan);
        //int count = 0;
        //foreach (var x in sortedArray)
        //{
        //    if (x < lessThan)
        //    {
        //        ++count;
        //    }
        //}
        //return count;
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    //}
}