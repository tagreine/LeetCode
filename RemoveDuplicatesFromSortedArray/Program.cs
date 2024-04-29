namespace RemoveDuplicatesFromSortedArray;

// ReSharper disable once ClassNeverInstantiated.Global
internal class Program
{
    private static void Main(string[] args)
    {
        var nums = new []{0,0,1,1,1,2,2,3,3,4};


        var unique = Solution.RemoveDuplicates(nums);
        Console.WriteLine($"{nameof(unique)}: {unique}");
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }
    
    private static class Solution {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null) throw new ArgumentNullException(nameof(nums));
            var len = nums.Length; 
            if (len == 1)
                return 1;
            
            var k = 1;
            foreach (var num in nums)
            {
                if (nums[k - 1] == num) continue;
                nums[k++] = num;
            }
            return k;
        }
    }
}