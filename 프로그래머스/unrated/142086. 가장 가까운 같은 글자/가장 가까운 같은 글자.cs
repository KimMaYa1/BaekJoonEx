using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        string str = "";
        
        for(int i = 0; i < s.Length; i++){
            bool y = str.Contains(s[i]);
            if(y){
                int j = i - str.LastIndexOf(s[i]);
                answer[i] = j;
            }
            else{
                answer[i] = -1;
            }
            str += s[i];
        }
        return answer;
    }
}