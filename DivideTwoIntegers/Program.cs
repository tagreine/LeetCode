namespace DivideTwoIntegers;

// ReSharper disable once ClassNeverInstantiated.Global
internal class Program
{
    private static void Main(string[] args)
    {
        var solve = Solution.Divide(-2147483647, 2);
        Console.WriteLine(solve);
    }
    
    private static class Solution {
        public static int Divide(int dividend, int divisor)
        {
            int k = 0;

            if (divisor == 0)
                throw new DivideByZeroException("divisor is zero");
            
            if (dividend == int.MinValue && divisor == -1)
                return int.MaxValue;
            if (dividend == int.MinValue && divisor == 1)
                return int.MinValue;
            
            if (dividend > 0 && divisor > 0)
            {
                while (dividend >= divisor)
                {
                    dividend -= divisor;
                    k++;
                }
            }
            
            else if (dividend > 0 && divisor < 0)
            {
                while (-dividend <= divisor)
                {
                    dividend += divisor;
                    k--;
                }
            }
            
            else if (dividend < 0 && divisor < 0)
            {
                while (dividend <= divisor)
                {
                    dividend -= divisor;
                    k++;
                }
            }
            
            else if (dividend < 0 && divisor > 0)
            {
                while (-dividend >= divisor)
                {
                    dividend += divisor;
                    k--;
                }
            }

            return k;
        }
    }
    
}