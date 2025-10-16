// non-efficient solution
public class Solution1 {
    public int[] TwoSum(int[] numbers, int target) {
        for (var i = 0; i < numbers.Length; i++) {
            for (var i1 = i + 1; i1 < numbers.Length; i1++) {
                if ((numbers[i] + numbers[i1]) == target) {
                    return new int[2]{ i + 1, i1 + 1 };
                }
            }
        }

        return new int[2]{ 0, 1 };
    }
}

// efficient solution
public class Solution2 {
    public int[] TwoSum(int[] numbers, int target) {
        var lPointer = 0;
        var rPointer = numbers.Length - 1;

        while (lPointer < rPointer) {
            int sum = numbers[lPointer] + numbers[rPointer];

            if (sum > target) {
                rPointer--;
            } else if (sum < target) {
                lPointer++;
            } else {
                return new int[2]{ lPointer + 1, rPointer + 1 };
            }
        }

        return new int[2];
    }
}
