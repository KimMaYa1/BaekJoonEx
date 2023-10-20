using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] strs = s.Split();
        float min = int.Parse(strs[0]);
        float max = int.Parse(strs[0]);
        for(int i = 0; i < strs.Length; i ++){
            min = MathF.Min(min, float.Parse(strs[i]));
            max = MathF.Max(max, float.Parse(strs[i]));
        }
        answer = $"{min} {max}";
        return answer;
    }
}