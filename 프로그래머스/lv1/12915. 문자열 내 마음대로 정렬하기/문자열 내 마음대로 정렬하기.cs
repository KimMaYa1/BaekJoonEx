using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = strings.OrderBy(num => num).OrderBy(num => num[n]).ToArray();
        
        return answer;
    }
}