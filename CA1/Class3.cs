using System;
using System.Collections.Generic;
using System.Xml;

public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        List<string> lis = new List<string>();
        XmlDocument xdoc = new XmlDocument();
        xdoc.LoadXml(xml);

        XmlNodeList xnList = xdoc.GetElementsByTagName("folder");
        foreach (XmlNode xn in xnList)
        {
            string attrVal = xn.Attributes["name"].Value;
            if (attrVal.StartsWith("u", StringComparison.InvariantCultureIgnoreCase))
            {
                lis.Add(attrVal);
            }
        }
        return lis;
    }

    //public static void Main(string[] args)
    //{
    //    string xml =
    //        "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
    //        "<folder name=\"c\">" +
    //            "<folder name=\"program files\">" +
    //                "<folder name=\"uninstall information\" />" +
    //            "</folder>" +
    //            "<folder name=\"users\" />" +
    //        "</folder>";

    //    foreach (string name in Folders.FolderNames(xml, 'u'))
    //        Console.WriteLine(name);
    //}
}