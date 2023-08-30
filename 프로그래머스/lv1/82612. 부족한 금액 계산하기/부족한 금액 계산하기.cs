using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long answer = 0;
        for(int i = 1; i <= count; i++){
            answer += price * i;
        }
        money -= answer;
        if(money > 0){
            return 0;
        }
        money *= -1;
        return money;
    }
}