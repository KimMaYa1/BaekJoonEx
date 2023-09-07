using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int temp = 0;
        while((n + temp)>=a){
            if(n >= a){
                answer += (n / a) * b;
                temp += n % a;
                n = (n / a) * b;
            }else{
                if(temp > 0){
                    n += temp;
                    temp = 0;
                }
            }
        }
        return answer;
    }
}