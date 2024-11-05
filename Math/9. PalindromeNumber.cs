public class Solution {
    public bool IsPalindrome(int x) {
        string xStr = x.ToString();
        int length = xStr.Length;

        for(int i = 0; i < length / 2; i++) {
            if (xStr[i] != xStr[length - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}