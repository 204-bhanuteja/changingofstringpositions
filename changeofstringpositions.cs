// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class swap
{
    static void Main(string[] args)
    {
        Console.WriteLine(first_last("bhanu"));
        Console.WriteLine(first_last("sonata"));
        Console.WriteLine(first_last("golla"));
    }
    public static string first_last(string ustr)
    {
        return ustr.Length > 1
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
    }
}
