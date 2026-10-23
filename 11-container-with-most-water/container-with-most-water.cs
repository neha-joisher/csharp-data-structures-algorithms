public class Solution {
    public int MaxArea(int[] height) {
        var max=0;
        int left=0;
        int right=height.Length-1;
        while(left<right){
            max=Math.Max(Math.Min(height[left],height[right])*(right-left),max);
            if(height[left]<=height[right]){
                left++;
            }else{
                right--;
            }
        }
        return max;
    }
}