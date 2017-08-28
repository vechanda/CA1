using System;

public class TextInput
{
    private string input;
    public virtual void Add(char c)
    {
        input = input + c;
    }
    public string GetValue()
    {
        return this.input;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        int result;
        if (Int32.TryParse(c.ToString(), out result))
        {
            base.Add(c);
        }
    }
}


public class UserInput
{
    //public static void Main(string[] args)
    //{
    //    TextInput input = new NumericInput();
    //    input.Add('1');
    //    input.Add('a');
    //    input.Add('0');
    //    Console.WriteLine(input.GetValue());
    //    Console.Read();
    //}
}