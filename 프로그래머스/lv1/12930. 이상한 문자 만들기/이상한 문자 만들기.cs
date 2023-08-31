using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split();
        for(int i = 0; i < str.Length; i++){
            for(int j = 0; j<str[i].Length; j++){
                if(j%2==0){
                    answer += str[i].Substring(j,1).ToUpper();
                }else{
                    answer += str[i].Substring(j,1).ToLower();
                }
            }
            if(i < str.Length - 1)
            answer+=" ";
        }
        
        return answer;
    }
}