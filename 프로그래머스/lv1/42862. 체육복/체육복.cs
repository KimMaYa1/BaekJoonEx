using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        int[] nArray = new int[n];
        
        for(int i = 0; i < nArray.Length; i++){
            nArray[i] = 1;
        }
            
        for(int i = 0; i < lost.Length; i++){
            nArray[lost[i]-1] = 0;
        }
        for(int i = 0; i < reserve.Length; i++){
            if(nArray[reserve[i]-1]!=0){
                nArray[reserve[i]-1] = 2;
            }else{
                nArray[reserve[i]-1] = 1;
            }
        }
        for(int i = 0; i < nArray.Length; i++){
            Console.Write(nArray[i] + " ");
        }
        Console.WriteLine();
        for(int i = 0; i < nArray.Length; i++){
            if(nArray[i] == 0){
                if(i == 0){
                    if(nArray[i+1] == 2){
                        nArray[i+1] = 1;
                        nArray[i] = 1;
                    }
                }
                else if(i == nArray.Length-1){
                    if(nArray[i-1] == 2){
                        nArray[i-1] = 1;
                        nArray[i] = 1;
                    }
                }
                else{
                    if(nArray[i-1] == 2){
                        nArray[i-1] = 1;
                        nArray[i] = 1;
                    }
                    else if(nArray[i+1] == 2){
                        nArray[i+1] = 1;
                        nArray[i] = 1;
                    }
                }
            }
            Console.Write(nArray[i] + " ");
        }
        for(int i = 0; i < nArray.Length; i++){
            if(nArray[i] == 2){
                nArray[i] = 1;
            }
            answer += nArray[i];
        }
        return answer;
    }
}