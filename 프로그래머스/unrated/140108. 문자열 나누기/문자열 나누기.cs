using System;

public class Solution {
    public int solution(string s) {
        int answer = 1;
        char c = '0';
        int count1 = 0;
        int count2 = 0;
        for(int i = 0; i < s.Length; i++){
            if(c == '0'){
                c = s[i];
            }
            if (c == s[i]){
                count1++;
            }  
            else{
                count2++;
            }
            if (count1 == count2 && i != s.Length - 1)
            {
                answer++;
                c = '0';
                count1 = 0;
                count2 = 0;
            }
        }
        
        return answer;
    }
}