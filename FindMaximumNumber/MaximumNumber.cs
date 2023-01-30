using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    internal class MaximumNumber
    {
        public class GenericMaximum<T> where T : IComparable
        {
            public T[] value;
            public GenericMaximum(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;

            }

            void add(params int[] a)
            {

            }


            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);

                return sorted_values[sorted_values.Length - 1];
            }

            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }

            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is " + max);
            }
        }







        class MaximumNumberCheck
        {
            public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }
                throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }

            public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return thirdValue;
                }
                throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }

            public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
            {
                if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                    firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                    firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
                {
                    return firstString;
                }

                if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                    secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                    secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
                {
                    return secondString;
                }

                if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                    thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                    thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
                {
                    return thirdString;
                }

                throw new Exception("firstNumber,secondNumber and thirdNumber are same");
            }

        }


























    }
}
