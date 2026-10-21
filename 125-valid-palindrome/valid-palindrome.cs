public class Solution {
    public bool IsPalindrome(string s) {
        var strs=s.ToLower();
        int left=0;
        int right=strs.Length-1;

        while(left<right){
            if (!IsAphaNumeric(strs[left])) {
                left++;
            } else if (!IsAphaNumeric(strs[right])) {
                right--;
            } else {
                if (strs[left] != strs[right]) return false;
                left++;
                right--;
            }
        }
        return true;

        }

    public bool IsAphaNumeric(char c){
        return (c>='a' && c<='z') || c>='A' && c<='Z' || c>='0' && c<='9';
    }
}