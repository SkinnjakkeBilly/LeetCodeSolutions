namespace leetcode{
    public class UniqueSubString {
    public int LengthOfLongestSubstring(string s) {
        int max = 0; 
        IDictionary<char, int> bokst = new Dictionary<char, int>();
        for(int i = 0; i<s.Length; i++){
            if(!bokst.ContainsKey(s[i])){
                bokst.Add(s[i], i);
                max = Math.Max(bokst.Count, max);
            }else{
                i=bokst[s[i]];
                bokst.Clear();
            }
        }
        return max;
    }
    
}
}