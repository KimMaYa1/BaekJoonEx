using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int num;
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                for(int k = j + 1; k < nums.Length; k++){
                    num = nums[i] + nums[j] + nums[k];
                    for(int l = 2; l <= num/2; l++){
                        if(num%l==0){
                            Console.WriteLine(num);
                            break;
                        }
                        if(l == num/2){
                            answer++;
                        }
                    }
                }
            }
        }

        return answer;
    }
}