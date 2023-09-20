using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int min;
        int count;
        for(int i = 0; i < targets.Length; i++){
            foreach(char ch in targets[i]){
                count = 0;
                min = keymap.Max(num => num.Length);
                for(int j = 0; j < keymap.Length; j++){
                    if(keymap[j].Contains(ch)){
                        if(keymap[j].IndexOf(ch) < min){
                            min = keymap[j].IndexOf(ch);
                        }
                    }
                    else{
                        count++;
                    }
                }
                if(min == keymap.Max(num => num.Length)){
                    answer[i] = -1;
                    break;
                }
                else{
                    answer[i] += min + 1;
                }
            }
        }
        
        return answer;
    }
}