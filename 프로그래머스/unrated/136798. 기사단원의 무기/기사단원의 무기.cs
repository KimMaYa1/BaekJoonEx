using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int count = 0;
        for(int i = 1; i <= number; i++){
            count = 0;
            int a = (int)Math.Sqrt(i);
            for(int j = 1; j <= a;j++){
                if(i % j == 0){
                    count+=2;
                }
                if((float)i/j == j){
                    count--;
                }
            }
            if(count > limit){
                count = power;
            }
            answer+=count;
        }
        return answer;
    }
}