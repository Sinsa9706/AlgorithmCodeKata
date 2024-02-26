public class Solution {
    public string solution(string s) {
        int num1 = (s.Length + 1) % 2;
        int num2 = (s.Length / 2) - num1;
        
        string answer = s.Substring(num2, num1 + 1);
        return answer;
    }
}