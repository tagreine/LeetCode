using System.Text;

namespace LongestCommonPrefix;

internal static class Program
{
    private static void Main(string[] args)
    {

        var input = new []{"flower", "flowwww", "flowaaer"};

        var solution = Solution.LongestCommonPrefix(input);
        
        Console.Write($"Common prefix: {solution}");
    }

    private static class Solution {
        public static string LongestCommonPrefix(string[]? strs)
        {
            if(strs == null || strs.Length == 0) return "";
            if(strs.Length == 1) return strs[0];
    
            var minLen = strs.Select(str => str.Length).Prepend(int.MaxValue).Min();

            var low = 1;
            var high = minLen;
            while(low <= high)
            {
                var middle = (low + high) / 2;
                if(IsCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }
    
            return strs[0].Substring(0, (low + high) / 2);
        }

        private static bool IsCommonPrefix(IReadOnlyList<string> strs, int len)
        {
            var str1 = strs[0][..len];
            for(var i = 1; i < strs.Count; i++)
                if(!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
    }
}