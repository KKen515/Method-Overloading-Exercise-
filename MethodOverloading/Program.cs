namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(2, 2);
            Add(2.4m, 2.5m);
            Add(0, 1, true);
        }
        public static int Add(int numOne, int numTwo)
        {
            var numberSum = numOne + numTwo;
            Console.WriteLine($"{numberSum}");
            return numberSum;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            var decimalSum = numOne + numTwo;
            Console.WriteLine($"{decimalSum}");
            return decimalSum;
        }

        public static String Add(int numOne, int numTwo, bool numIsTrue)
        {
            var sum = numOne + numTwo;
            if (numIsTrue == true && sum > 1)
            {
                Console.WriteLine($"{sum} dollars");
                return $"{sum} dollars";
            }
            else if (numIsTrue == true && sum == 1)
            {
                Console.WriteLine($"{sum} dollar");
                return $"{sum} dollar";
            }
            else if (numIsTrue == true)
                {
                    Console.WriteLine($"{sum} dollars");
                    return $"{sum} dollars";

                }else
            {
                return sum.ToString();
            }

        }

    }
}

