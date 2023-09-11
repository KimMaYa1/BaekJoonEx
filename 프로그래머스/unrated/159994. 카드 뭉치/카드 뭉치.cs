using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        string go = "";
        int count1 = 0;
        int count2 = 0;
        foreach(string str in goal){
            go += str;
            if(count1 >= cards1.Length){
                count1 = cards1.Length-1;
            }else if(count2 >= cards2.Length){
                count2 = cards2.Length-1;
            }
            
            if(str.Equals(cards1[count1])){
                answer +=cards1[count1];
                count1++;
            }
            else if(str.Equals(cards2[count2])){
                answer +=cards2[count2];
                count2++;
            }
            
            else{
                answer = "No";
                break;
            }
        }
        if(answer.Equals(go)){
                answer = "Yes";
        }
        return answer;
    }
}