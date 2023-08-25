using System;
public class Solution {
    public long solution(long n) {
        double answer = 0;
        answer = Math.Sqrt(n);
        if((long)answer * (long)answer == n)
        {
            return (long)Math.Pow(answer+1,2);
        }
        return -1;
    }
}