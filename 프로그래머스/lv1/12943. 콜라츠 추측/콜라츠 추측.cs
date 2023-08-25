public class Solution {
    public int solution(int num) {
        int i = 0;
        if(num != 1)
            while(num != 1 && i++ < 500)
            {
                if(num % 2 == 0)
                    num /= 2;
                else if(num % 2 == 1)
                    num = num * 3 + 1;
            }
        
        if(i >= 500)
            i = -1;
        
        return i;
    }
}