public class Solution {
    public bool solution(int x) {
        string str = x.ToString();
        int arr = 0;
        bool answer = true;
        int num = x;
        for(int i = 0; i < str.Length; i++)
        {
            arr += x % 10;
            x /= 10;
        }
        
        if(num % arr == 0)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        
        return answer;
    }
}