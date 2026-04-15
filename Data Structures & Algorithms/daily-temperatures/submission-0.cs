public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // [30,38,30,36,35,40,28]
        var l = temperatures.Length;
        var res = new int[l];
        if (l == 0) return new int[1] {0};
        var st = new Stack<int>();
        for (int i = 0; i < l; i++) {
            if (st.Count == 0 || temperatures[i] <= temperatures[st.Peek()]) st.Push(i);
            else {
                int ndx = 0;
                while (st.Count > 0 && temperatures[st.Peek()] < temperatures[i]) {
                    ndx = st.Pop();
                    res[ndx] = i - ndx;
                }                
                st.Push(i);
            }
        }
        return res;
    }
}
