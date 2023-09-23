using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> temp = ingredient.ToList();
        
        for(int i = 0; i < temp.Count - 3; i++){
            if(i < 0){
                i = 0;
            }
            if(temp[i] == 1)
                if(temp[i+1] == 2)
                    if(temp[i+2] == 3)
                        if(temp[i+3] == 1){
                            answer++;
                            temp.RemoveRange(i,4);
                            i -= 4;
                        }
        }
        return answer;
    }
}