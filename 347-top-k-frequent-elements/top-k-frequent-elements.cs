public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap=new Dictionary<int,int>();
        foreach(int i in nums){
            if(freqMap.ContainsKey(i)){
                freqMap[i]++;
            }else{
                freqMap[i]=1;
            }
        }
        var freqBucketList=new List<int>[nums.Length + 1];
        for(int i=0;i<freqBucketList.Length;i++){
            freqBucketList[i]=new List<int>();
        }
        foreach(var kvp in freqMap){
            freqBucketList[kvp.Value].Add(kvp.Key);
        }
        var result=new int[k];
        int j=0;
        for(int i=freqBucketList.Length - 1;i>=0;i--){
            foreach(int num in freqBucketList[i]){
                if(j<k){
                    result[j]=num;
                    j++;
                }
            }
        }
        return result;
    }
}