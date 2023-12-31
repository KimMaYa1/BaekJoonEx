using System.Linq;
using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        s = s.ToLower();
        char[] temp = s.ToCharArray();
        
        temp[0] = Char.ToUpper(temp[0]);
        
        for(int i = 0; i < temp.Length; i++)
        {
            if(temp[i] == ' ' && i + 1 < temp.Length){
                temp[i + 1] = Char.ToUpper(temp[i + 1]);
            }
        }
        
        for (int i = 0; i < temp.Length; i++)
        {
            answer += temp[i];
        }
        
        return answer;
    }
}