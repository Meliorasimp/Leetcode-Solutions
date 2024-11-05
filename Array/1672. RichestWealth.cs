public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;

        for (int i = 0; i < accounts.Length; i++) {
        int currentWealth = 0;

        for (int j = 0; j < accounts[i].Length; j++) {
            currentWealth += accounts[i][j];
        }

        if (currentWealth > maxWealth) {
            maxWealth = currentWealth;
        }
    }
        return maxWealth;
    }
}