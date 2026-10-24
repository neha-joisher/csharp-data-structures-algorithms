public class Solution {
    public int Trap(int[] height) {
        int volume=0;
        int[] leftMax=new int[height.Length];
        int[] rightMax=new int[height.Length];

        for(int i=1;i<height.Length;i++){
            leftMax[i]=Math.Max(leftMax[i-1],height[i-1]);
        }

        for(int i=height.Length-2;i>=0;i--){
            rightMax[i]=Math.Max(rightMax[i+1],height[i+1]);
        }

        for(int i=0;i<height.Length;i++){
            volume+=Math.Max((Math.Min(leftMax[i],rightMax[i])-height[i]),0);
        }

        return volume;

    }
}