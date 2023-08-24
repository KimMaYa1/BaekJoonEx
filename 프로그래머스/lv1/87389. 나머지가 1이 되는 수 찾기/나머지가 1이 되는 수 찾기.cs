using System;

public class Solution {
    public int solution(int n) {
        int answer = 2;
        int num = 3;
        while(true)
        {
            if(n < 3)
            {
                break;
            }
            else if(n % answer == 1)
            {
                num = answer;
                break;
            }
            answer++;
        }
        return num;
    }
}