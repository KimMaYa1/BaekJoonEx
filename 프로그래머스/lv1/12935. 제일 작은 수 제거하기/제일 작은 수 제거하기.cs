using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int min = arr.Min();
        int[] answer = arr.Except(new int[]{min}).ToArray();
        if(answer.Length == 0)
            answer = new int[] {-1};
        return answer;
    }
}