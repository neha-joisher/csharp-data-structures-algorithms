public class Solution {
    public bool IsAnagram(string s, string t) {
        var freqMapS=CreateFreqMap(s);
        var freqMapT=CreateFreqMap(t);

        //compare two dictionaries - if same return true ortherwise return false;
        if(freqMapS.Count!=freqMapT.Count){
            return false;
        }

        foreach(var pair in freqMapS){
            // if(! (freqMapT.ContainsKey(pair.Key)) || freqMapT[pair.Key]!=freqMapS[pair.Key]){
            //     return false;
            // }
            if(! (freqMapT.TryGetValue(pair.Key,out var value)) || value!=freqMapS[pair.Key]){
                return false;
            }
        }
        return true;

    }

    public Dictionary<char,int> CreateFreqMap(string s){
        var freqMap=new Dictionary<char,int>();
        foreach(char c in s){
            if(freqMap.ContainsKey(c)){
                freqMap[c]++;
            }else{
                freqMap[c]=1;
            }
        }
        return freqMap;
    }
}