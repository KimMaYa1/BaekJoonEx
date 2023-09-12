using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[3];
        int[] s1 = {1,2,3,4,5};
        int[] s2 = {2,1,2,3,2,4,2,5};
        int[] s3 = {3,3,1,1,2,2,4,4,5,5};
        
        for(int i = 0; i < answers.Length; i++){
            if(answers[i]==s1[i%s1.Length]) 
                answer[0]++;
            if(answers[i]==s2[i%s2.Length]) 
                answer[1]++;
            if(answers[i]==s3[i%s3.Length]) 
                answer[2]++;
        }
        List<int> score = new List<int>();
        if(answer.Max()==answer[0]){
            score.Add(1);
        }
        if(answer.Max()==answer[1]){
            score.Add(2);
        }
        if(answer.Max()==answer[2]){
            score.Add(3);
        }
            
        return score.ToArray();
    }
}