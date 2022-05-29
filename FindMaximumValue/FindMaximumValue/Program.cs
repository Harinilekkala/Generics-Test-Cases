using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    
    public static void Main(string[] args)
    {
        
        

        FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();
        findmaximumInteger.findMax<int>(30, 20, 10);
        findmaximumInteger.findMax<float>(10.5F, 20.5F, 30.5F);
        findmaximumInteger.findMax<string>("Apple", "Banana", "Orange");
    }
}
