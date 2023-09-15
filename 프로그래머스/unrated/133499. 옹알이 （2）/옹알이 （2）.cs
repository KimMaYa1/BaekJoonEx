using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        for(int i = 0; i < babbling.Length; i++){
            if(babbling[i].Contains("ayaaya")){
                continue;
            }
            if(babbling[i].Contains("yeye")){
                continue;
            }
            if(babbling[i].Contains("woowoo")){
                continue;
            }
            if(babbling[i].Contains("mama")){
                continue;
            }
            if(babbling[i].Contains("aya")){
                babbling[i] = babbling[i].Replace("aya"," ");
            }
            if(babbling[i].Contains("ye")){
                babbling[i] = babbling[i].Replace("ye"," ");
            }
            if(babbling[i].Contains("woo")){
                babbling[i] = babbling[i].Replace("woo"," ");
            }
            if(babbling[i].Contains("ma")){
                babbling[i] = babbling[i].Replace("ma"," ");
            }
            babbling[i] = babbling[i].Replace(" ","");
            if(babbling[i] == ""){
                answer++;
            }
        }
        return answer;
    }
}