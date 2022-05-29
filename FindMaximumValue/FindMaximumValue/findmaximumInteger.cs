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



        public float FindMaxFloat(float firstValue, float secondValue, float thirdValue)
        {
            float floatMaxValue;
            if (firstValue > secondValue && firstValue > thirdValue)
            {
                floatMaxValue = firstValue;
            }
            else if (secondValue > firstValue && secondValue > thirdValue)
            {
                floatMaxValue = secondValue;
            }
            else
            {
                floatMaxValue = thirdValue;
            }
            Console.WriteLine(floatMaxValue);
            return floatMaxValue;
        }
        public string findMaxString(string firstValue, string secondValue, string thirdValue)
        {
            string floatMaxValue;
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                floatMaxValue = firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                floatMaxValue = secondValue;
            }
            else
            {
                floatMaxValue = thirdValue;
            }
            Console.WriteLine(floatMaxValue);
            return floatMaxValue;
        }
    }
}
