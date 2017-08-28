using System;
using System.Collections.Generic;

public class TrainComposition
{
    private LinkedList<int> ll = new LinkedList<int>();

    public void AttachWagonFromLeft(int wagonId)
    {
        ll.AddFirst( wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        ll.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        return ll.First.Value;
    }

    public int DetachWagonFromRight()
    {
        return ll.Last.Value;
    }

    //public static void Main(string[] args)
    //{
    //    TrainComposition tree = new TrainComposition();
    //    tree.AttachWagonFromLeft(7);
    //    tree.AttachWagonFromLeft(13);
    //    tree.AttachWagonFromLeft(15);
    //    tree.AttachWagonFromLeft(16);
    //    Console.WriteLine(tree.DetachWagonFromRight()); // 7 
    //    Console.WriteLine(tree.DetachWagonFromLeft()); // 13
    //}
}