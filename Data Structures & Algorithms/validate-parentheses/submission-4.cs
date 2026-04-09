public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> pairs = new Dictionary<char, char>(){
            {')', '('},
            {']', '['},
            {'}', '{'}
        };
        Stack<char> stack = new Stack<char>();
        foreach(char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            }
            else if (pairs.ContainsKey(c)) {
                if (stack.Count != 0 && stack.Peek() == pairs[c])
                    stack.Pop();
                else
                    return false;
            }
        }
        return stack.Count == 0;
    }
}