public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int numLen = nums.Count();
        for (int i = 0; i < numLen; i++)
        {
            int complem = target - nums[i];
            
            if (dict.ContainsKey(complem))
            {
                int indcomplem;
                dict.TryGetValue(complem, out indcomplem);
                int[] sol = new int[] { indcomplem, i };
                return sol;
            }

            else if (!dict.ContainsKey(nums[i]))

            {
                dict.Add(nums[i], i);
            }
        }
        throw new Exception("No two sum solution.");
    }
}