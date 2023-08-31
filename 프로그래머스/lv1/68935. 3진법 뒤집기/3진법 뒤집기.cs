using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> answer = new List<int>();
        while(n > 0){
            answer.Add(n%3);
            n /= 3;
        }
        for(int i = 0; i < answer.Count; i++){
            n += (int)Math.Pow(3, answer.Count-i-1) * answer[i];
        }
        return n;
    }
}