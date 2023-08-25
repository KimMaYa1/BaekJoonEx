using System;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[0];
        int a = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[a++] = arr[i];
            }
        }
        Array.Sort(answer);
        if(a == 0)
        {
            Array.Resize(ref answer, answer.Length + 1);
            answer[a++] = -1;
        }
            
        return answer;
    }
}