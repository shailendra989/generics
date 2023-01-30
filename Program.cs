namespace GenricsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            bool[] boolArr = { true, false };
            //GenericsMethod.toPrint(intArray);
            //GenericsMethod.toPrint(doubleArray);
            //GenericsMethod.toPrint(charArray);

            //GenericsMethod.toPrint<int>(intArray);
            //GenericsMethod.toPrint<double>(doubleArray);
            //GenericsMethod.toPrint<char>(charArray);
            //GenericsMethod.toPrint<bool>(boolArr);
            //PrintArray<int> obj = new PrintArray<int>(intArray);
            //obj.toPrint();



        }
    }
}