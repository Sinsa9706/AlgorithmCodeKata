using System;

public class Solution {
    public int solution(int num1, int num2) {
        float a = (float)num1;
        float b = (float)num2;
        float c = a/b;
        c *= 1000;
        int answer = (int)c;
        return answer;
    }
}