using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int[,] nums = new int[sizes.GetLength(0),sizes.GetLength(1)];
        int w = 0, h= 0;
        for(int i = 0; i< nums.GetLength(0); i++){
            nums[i,0] = Math.Max(sizes[i,1], sizes[i,0]);
            nums[i,1] = Math.Min(sizes[i,1], sizes[i,0]);
        }
        for(int i = 0; i < nums.GetLength(0); i++){
            int rw = w;
            w = Math.Max(w, nums[i,0]);    //가로길이
        }
        for(int i = 0; i < nums.GetLength(0); i++){
            int rh = h; 
            h = Math.Max(h, nums[i,1]);
            if(rh >= nums[i,0]&& w >= h){
                h = rh;
            }
        }
        answer = w * h;
        return answer;
    }
}