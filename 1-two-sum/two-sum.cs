public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictionary=new Dictionary<int,int>(); //value,index
        for(int i=0;i<nums.Length;i++){
            if(dictionary.ContainsKey(target-nums[i])){
                return new int[]{dictionary[target-nums[i]],i};
            }else{
                dictionary[nums[i]]=i;
            }
        }
        return new int[2];
    }
}