using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for(int i = 1; i < 10; i++){
            answer += i;
            for(int j = 1; j < numbers.Length+1; j++){
                if(numbers[j-1] == i){
                    answer -= i;
                    break;
                }
            }
        }
        return answer;
    }
}