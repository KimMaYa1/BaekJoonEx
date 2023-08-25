using System;
public class Solution {
    public long solution(long n) {
        string str = n.ToString();
        long[] answer = new long[str.Length];
        
        for(int i = 0; i < str.Length; i ++)
        {
            answer[i] = n % 10;
            n /= 10;
        }
        
        for(int i = 0; i < answer.Length; i++)
        {
            for(int j = i; j < answer.Length; j++)
            {
                if(answer[i] < answer[j])
                {
                    long temp = answer[i];
                    answer[i] = answer[j];
                    answer[j] = temp;
                }
            }
            n += answer[i];
            n *= 10;
        }
        return n / 10;
    }
}