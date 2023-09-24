using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        int minX = wallpaper[0].Length;
        int maxX = 0;
        int minY = wallpaper.Length;
        int maxY = 0;
        int count = 0;
        foreach(string str in wallpaper){
            for(int i = 0; i < str.Length; i++){
                if(str[i] == '#'){
                    minX = Math.Min(minX,i);
                    minY = Math.Min(minY,count);
                    maxX = Math.Max(maxX,i);
                    maxY = Math.Max(maxY,count);
                }
            }
            count++;
        }
        answer[0] = minY;
        answer[1] = minX;
        answer[2] = maxY+1;
        answer[3] = maxX+1;
        return answer;
    }
}