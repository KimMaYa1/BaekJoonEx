using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        string[] dic = new string[routes.Length];
        int[] dir = new int[routes.Length];
        int[] w = new int[2],h = new int[2];
        bool isNext;
        for(int i = 0; i < park.Length; i++){
            if(park[i].Contains("S")){
                w[0] = park[i].IndexOf("S");
                break;
            }
            else{
                h[0]++;
            }    
        }
        
        for(int i = 0; i < routes.Length; i++){
            isNext = true;
            dic[i] += routes[i][0];
            dir[i] = int.Parse(routes[i].Substring(routes[i].IndexOf(" ")+1));
            w[1] = w[0];
            h[1] = h[0];
            
            for(int j = 0; j < dir[i]; j++){
                if(dic[i] =="W"){
                    if(w[1] > 0){
                        if(park[h[1]][w[1]-1]!='X'){
                            w[1]--;
                        }else{
                            isNext = false;
                            break;
                        }
                    }
                    else{
                        isNext = false;
                        break;
                    }
                }
                else if(dic[i] == "E"){
                    if(w[1] < park[h[1]].Length-1){
                        if(park[h[1]][w[1]+1]!='X'){
                            w[1]++;
                        }else{
                            isNext = false;
                            break;
                        }
                    }
                    else{
                        isNext = false;
                        break;
                    }
                }
                else if(dic[i] =="N"){
                    if(h[1] > 0){
                        if(park[h[1]-1][w[1]]!='X'){
                            h[1]--;
                        }else{
                            isNext = false;
                            break;
                        }
                    }
                    else{
                        isNext = false;
                        break;
                    }
                }
                else if(dic[i] =="S"){
                    if(h[1] < park.Length-1){
                        if(park[h[1]+1][w[1]]!='X'){
                            h[1]++;
                        }else{
                            isNext = false;
                            break;
                        }
                    }
                    else{
                        isNext = false;
                        break;
                    }
                }
            }
            
            
            if(isNext){
                w[0] = w[1];
                h[0] = h[1];
            }
        }
        
        answer[0] = h[0];
        answer[1] = w[0];
        
        return answer;
    }
}