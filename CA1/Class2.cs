using System;
using System.Collections.Generic;

class TwoSum
{
    public static IEnumerable<Tuple<int, int>> FindTwoSum(IList<int> list, int sum)
    {

        if (list != null && list.Count > 0)
        {
            
            for (int a = 0; a < list.Count; a++)
            {
                for (int b = 0; b < list.Count; b++)
                {
                    if ((list[a] + list[b]) == sum)
                    {
                        yield return new Tuple<int, int>(a, b);
                    } 
                }
            }
        }
    }

    //public static void Main(string[] args)
    //{
    //    var indices1 = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
    //    foreach(var indices in indices1)
    //    Console.WriteLine(indices.Item1 + " " + indices.Item2);
    //    Console.Read();
    //}
} 