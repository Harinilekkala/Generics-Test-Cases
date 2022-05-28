using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    private static object nlog;

    public static object Nlog { get; private set; }
    public static object NLog { get; private set; }

    public static void Main(string[] args)
    {
        
        

        FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();
        findmaximumInteger.findMax(30, 20, 10);

    }
}
