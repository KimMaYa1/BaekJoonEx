using System;
public class Solution {
    public bool solution(string s) {
        int num = 0;
        if(s.Length != 4 && s.Length != 6)
        {
            return false;
        }
        else if(!int.TryParse(s, out num))
        {
            return false;
        }
        return true;
    }
}