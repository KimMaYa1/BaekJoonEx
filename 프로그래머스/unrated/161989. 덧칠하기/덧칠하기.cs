using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 1;
        int result = m-1;
        for(int i = 1; i < section.Length; i++){
            result -= section[i] - section[i-1];
            if(result < 0){
                answer++;
                result = m - 1;
            }
        }
        return answer;
    }
}