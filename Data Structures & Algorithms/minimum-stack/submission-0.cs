public class MinStack {
    List<int> stack;
    List<int> minS;

    public MinStack() {
        stack = new List<int>();
        minS = new List<int>();
    }
    
    public void Push(int val) {
        stack.Add(val);
        minS.Add(Math.Min(val, minS.Count == 0 ? val : minS[minS.Count - 1]));
    }
    
    public void Pop() {
        stack.RemoveAt(stack.Count - 1);
        minS.RemoveAt(minS.Count - 1);
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return minS[minS.Count - 1];
    }
}
