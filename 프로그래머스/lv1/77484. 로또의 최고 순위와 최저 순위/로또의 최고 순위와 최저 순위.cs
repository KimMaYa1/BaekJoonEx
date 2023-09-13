using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int count = 0;
        int nullcount = 0;
        int num = 6;
        for(int i = 0 ; i < lottos.Length; i++){
            if(lottos[i] == 0 ){
                nullcount++;
            }
            else if(Array.Find(win_nums,element => element == lottos[i]) == lottos[i]){
                 count++;
            }
        }
        answer[0] = LottoNum(count+nullcount);
        answer[1] = LottoNum(count);
        return answer;
    }
    
    int LottoNum(int num){
        switch(num){
            case 6 :
                num = 1;
                break;
            case 5 :
                num = 2;
                break;
            case 4 :
                num = 3;
                break;
            case 3 :
                num = 4;
                break;
            case 2 :
                num = 5;
                break;
            case 1 :
            case 0 :
                num = 6;
                break;
        }
        return num;
    }
}