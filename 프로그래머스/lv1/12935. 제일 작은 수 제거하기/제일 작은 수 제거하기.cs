using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length-1];
        int min = arr[0];
        if(answer.Length==0){
            answer = new int[1] {-1};
        } else
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            answer = arr.Except(new int[] { min }).ToArray();
        }
        return answer;
    }
}