using System;
public class Solution {
    public string solution(string s) {
        char[] answer = s.ToCharArray();
        Array.Sort(answer);
        Array.Reverse(answer);
        s = new string(answer);
        return s;
    }
}