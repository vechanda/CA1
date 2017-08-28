using System;

    public class Path
{
    public string CurrentPath { get; private set; }

    public Path(string path)
    {
        this.CurrentPath = path;
    }
    public Path Cd(string newPath)
    {
        String[] newP = newPath.Split('/');
        String[] oldP = CurrentPath.Split('/');
        int lnCount = 0;
        foreach (String str in newP)
        {
            if (str.Equals(".."))
            {
                lnCount++;
            }
        }

        int len = oldP.Length;
        String strOut = "";
        for (int i = 0; i < len - lnCount; i++)
        {
            strOut = strOut + oldP[i] + "/";
        }

        len = newP.Length;
        for (int i = 0; i < len; i++)
        {
            if (!newP[i].Equals(".."))
            {
                strOut = strOut + newP[i] + "/";
            }
        }
        CurrentPath = strOut.Substring(0, strOut.Length - 1);
        Console.WriteLine(CurrentPath);
        if (CurrentPath.IndexOf("/") < 0)
            throw new Exception("Directory not found");
        return this;
    }
}


class Program
{


    static void Main(string[] args)
    {
        Path path = new Path("/a/b/c/d");
        Console.WriteLine(path.Cd("../x").CurrentPath);
        //console.read();
    }


}