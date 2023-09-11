using System;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int count = 1;
        int min = 9999;
        Array.Sort(score);
        foreach(int i in score.Reverse()){
            if (min > i)
                min = i;

            if (count == m)
            {
                count = 0;
                answer += min * m;
                min = 9999;
            }
            count++;
        }
        return answer;
    }
}