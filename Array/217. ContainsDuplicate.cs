public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        /*array.Sort(nums);

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i-1]) {
                return true;
            }
            
        }
        return true;*/

        HashSet<int> set = new HashSet<int>(nums);
        
        return nums.Length != set.Count;
    }
}