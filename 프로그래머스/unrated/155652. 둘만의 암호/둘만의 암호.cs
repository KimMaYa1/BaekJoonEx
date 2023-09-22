using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char a = ' ';
        foreach(char ch in s){
            int b = ch;
            for(int i = 0; i < index; i++){
                b++;
                if(b > 122){
                    b = 97;
                }
                while(skip.Contains((char)b)){
                    b++;
                    if(b>122){
                        b = 97;
                    }
                }
            }
            if(b >= 97 && b <= 122){
                a = (char)b;
            }
            answer += a;
        }
        return answer;
    }
}