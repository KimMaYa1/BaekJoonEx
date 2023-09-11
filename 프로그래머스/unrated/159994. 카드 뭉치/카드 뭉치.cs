using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int count1 = 0;
        int count2 = 0;
        foreach(string str in goal){
            if(count1 < cards1.Length&& str.Equals(cards1[count1])){
                count1++;
            }
            else if(count2 < cards2.Length && str.Equals(cards2[count2])){
                count2++;
            }
            
            else{
                answer = "No";
            }
        }
        return answer;
    }
}