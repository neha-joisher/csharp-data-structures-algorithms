public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen=new Dictionary<int,int>(); //value,index
        for(int i=0;i<nums.Length;i++){
            if(seen.TryGetValue(target-nums[i], out int j)){
                return new int[]{j,i};
            }else{
                seen[nums[i]]=i;
            }
        }
        return new int[2];
    }
}