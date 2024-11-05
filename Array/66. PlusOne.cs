public class Solution {
    public int[] PlusOne(int[] digits) {
       int n = digits.Length;
        
        for (int i = n - 1; i >= 0; i--) {
            digits[i]++;
            if (digits[i] <= 9) {
                return digits;
            }
            digits[i] = 0;
        }
        int[] newNumber = new int[n + 1];
        newNumber[0] = 1;
        
        return newNumber;
    }
}