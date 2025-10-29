public class Solution {
    public int Trap(int[] height) {
       if (height.Length == 0) {
          return 0;
       }
       var prevStack = new Stack<int>();

       var result = 0;

       for (var i = 0; i < height.Length; i++) {
          while (prevStack.Count > 0 && height[i] > height[prevStack.Peek()]) {
            var mid = height[prevStack.Pop()];
            if (prevStack.Count > 0) {
                var right = height[i];
                var left = height[prevStack.Peek()];
                var h = Math.Min(right, left) - mid;
                var w = i - prevStack.Peek() - 1;
                result += h * w;
            }
          }

          prevStack.Push(i);
       }

       return result;
    }
}
