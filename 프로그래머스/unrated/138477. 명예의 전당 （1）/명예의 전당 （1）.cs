using System;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        int[] temp = new int[k];
        int count = 0;
        int min = 0;
        for(int i = 0; i < score.Length; i++){
            if(temp[count] < score[i]){
                temp[count] = score[i];
            }
            for(int j = 0; j < k-1; j++){
                if(temp[j] < temp[j+1]){
                    min = temp[j];
                    temp[j] = temp[j+1];
                    temp[j+1] = min;
                }
            }
            answer[i] = temp[count];
            if(count<k-1){
                count++;
            }
        }
        return answer;
    }
}