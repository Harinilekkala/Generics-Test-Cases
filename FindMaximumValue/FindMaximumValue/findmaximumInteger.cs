using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumValue
{
    public class findmaximumInteger
    {
        public int findMax(int firstValue, int secondValue, int thirdValue)
        {
            int maxValue;
            if (firstValue > secondValue && firstValue > thirdValue)
            {
                maxValue = firstValue;
            }
            else if (secondValue > firstValue && secondValue > thirdValue)
            {
                maxValue = secondValue;
            }
            else
            {
                maxValue = thirdValue;
            }
            Console.WriteLine(maxValue);
            return maxValue;

        }
    }
}
