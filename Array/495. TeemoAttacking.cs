public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        if (timeSeries.Length == 0) return 0;   
        int totalPoisonedTime = 0;      
        for (int i = 0; i < timeSeries.Length - 1; i++) {
            int timeDifference = timeSeries[i + 1] - timeSeries[i];
            if (timeDifference < duration) {
                totalPoisonedTime += timeDifference;
            } else {
                totalPoisonedTime += duration;
            }
        }
        totalPoisonedTime += duration;
        
        return totalPoisonedTime;
    }
}