public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        string[] Days = {
            "SUN","MON","TUE","WED","THU","FRI","SAT"
        };
        int count = 5;
        if(a > 7){
            a += 1;
        }
        for(int i = 1; i <= a; i++){
            if( i == 8)
                i++;
            int d = (i==a)? b : ((i % 2 == 0) ? ((i == 2)? 29 : 30) : 31);
            for(int j = 0; j < d; j++){
                answer = Days[count];
                count++;
                if(count == 7){
                    count = 0;
                }
            }
        }
        return answer;
    }
}