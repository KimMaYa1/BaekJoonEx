public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[n.ToString().Length];
        
        int i = 0;
        while(n > 0)
        {
            answer[i] = (int)(n % 10);
            i++;
            n = n / 10;
        }
        return answer;
    }
}