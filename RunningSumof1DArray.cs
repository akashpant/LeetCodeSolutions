/*
Intuition
You will observe the next element is simply the sum of its preceding element and it self.

Approach
As the original array is not needed, updating each index as sum of previous and current index will provide the required array.

Complexity
Time complexity:
O(n)
Space complexity:
O(1)
*/

//Code
public class Solution {
  public int[] RunningSum(int[] nums) {
    for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
    return nums;
  }
}
