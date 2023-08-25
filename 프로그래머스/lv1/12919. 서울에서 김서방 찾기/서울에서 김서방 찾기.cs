public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int i = 0;
        foreach(string str in seoul)
        {
            if(str != "Kim")
            {
                i++;
            }else{
                break;
            }
        }
        
        return $"김서방은 {i}에 있다";
    }
}