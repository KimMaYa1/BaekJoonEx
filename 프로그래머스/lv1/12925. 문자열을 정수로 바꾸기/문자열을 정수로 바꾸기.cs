public class Solution {
    public int solution(string s) {
        int answer = 0;
        string str = s.Substring(0,1);
        
        
        if(int.TryParse(str, out int x))
        {
            str = s.Substring(0, s.Length);
            answer = int.Parse(str);
        }
        else
        {
            str = s.Substring(1, s.Length-1);
            answer = int.Parse(str);
            if(s[0] == '-')
            {
                answer = answer * -1;
            }
        }
        
        return answer;
    }
}