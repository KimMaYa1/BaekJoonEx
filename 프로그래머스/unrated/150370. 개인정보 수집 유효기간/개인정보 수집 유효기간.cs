using System;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] answer = new int[] {};
        int[] monuthCount = new int[terms.Length];
        string[] monuthType = new string[terms.Length];
        string[] nowDay = today.Split(".");
        int a = 0;
        int av = 0;
        for(int i = 0; i < monuthCount.Length; i++){
            monuthCount[i] = int.Parse(terms[i].Substring(terms[i].IndexOf(" ")));
            monuthType[i] = terms[i].Substring(0,terms[i].IndexOf(" "));
        }
        
        for(int i = 0; i < privacies.Length; i++){
            string[] dayStr = privacies[i].Split(".");
            Array.Resize(ref dayStr, 4);
            dayStr[3] = dayStr[2].Substring(dayStr[2].IndexOf(" ")+1);
            dayStr[2] = dayStr[2].Substring(0,dayStr[2].IndexOf(" "));
            string count = dayStr[3];
            for(int j = 0; j < monuthType.Length; j++){
                if(count == monuthType[j]){
                    a = monuthCount[j];
                }
            }
            dayStr[1] = "" + (int.Parse(dayStr[1]) + a);
            dayStr[2] = "" + (int.Parse(dayStr[2]) - 1);
            if(int.Parse(dayStr[2]) <= 0){
                dayStr[1] = "" + (int.Parse(dayStr[1]) - 1);
                dayStr[2] = "28";
            }
            while(int.Parse(dayStr[1]) > 12){
                dayStr[1] = "" + (int.Parse(dayStr[1]) - 12);
                dayStr[0] = "" + (int.Parse(dayStr[0]) + 1);
            }
            
            Console.Write(dayStr[0] + "." + dayStr[1] + "." + dayStr[2]);
            
            if(int.Parse(nowDay[0]) > int.Parse(dayStr[0])){
                Array.Resize(ref answer, answer.Length + 1);
                answer[av] = i + 1;
                av++;
            }
            else if (int.Parse(nowDay[0]) == int.Parse(dayStr[0])){
                if(int.Parse(nowDay[1]) > int.Parse(dayStr[1])){
                    Array.Resize(ref answer, answer.Length + 1);
                    answer[av] = i + 1;
                    av++;
                }
                else if (int.Parse(nowDay[1]) == int.Parse(dayStr[1])){
                    if(int.Parse(nowDay[2]) > int.Parse(dayStr[2])){
                        Array.Resize(ref answer, answer.Length + 1);
                        answer[av] = i + 1;
                        av++;
                    }
                }
            }
        }
        
        
        return answer;
    }
}