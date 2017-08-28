using System;
using System.Linq;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        var verifiedWord = GetVerifiedString(word);
        //if (!String.IsNullOrWhiteSpace(verifiedWord))
        //{
        //    var str = new String(verifiedWord.Reverse().ToArray());
        //    return VerifyString(verifiedWord, str);
        //}
        //return false;

        return VerifyString(ReverseString_Rec(word), word);
    }

    private static string ReverseString_Rec(string str)
    {
        if (str.Length <= 1)
            return str;
        else
            return ReverseString_Rec(str.Substring(1)) + str[0];
    }

    private static bool VerifyString(string verifiedWord, string str)
    {
        if (String.Equals(verifiedWord, str, StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }
        return false;
    }

    public static bool IsPalindrome1(string word)
    {
        var verifiedWord = GetVerifiedString(word);
        int len = verifiedWord.Length;
        if (len <= 1)
        { return true; }
        char[] revStr = new char[len];
        for (int i = len-1, j =0; i >= 0; i--, j++)
        {
            revStr[j] = verifiedWord[i];

        }
        return VerifyString(new string(revStr), word);
    }

    private static string GetVerifiedString(string input)
    {
        return !string.IsNullOrWhiteSpace(input) ? input.Trim() : null;        
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(IsPalindrome("ww"));
    //    Console.ReadKey();
    //}
}