public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result=new Dictionary<string,List<string>>();
        foreach(string s in strs){
            var freqArray=new int[26];
            foreach(char c in s){
                freqArray[c-'a']++;
            }
            var key=string.Join(",",freqArray);
            if(result.ContainsKey(key)){
                result[key].Add(s);
            }else{
                result[key]=new List<string>{s};
            }
        }
        return result.Values.ToList<IList<string>>();
    }
}