namespace leetcode{
public class LetterCombinations {
    public static IList<string> letterCombinations(string digits) {
        
        Dictionary<int, string> numMap= new Dictionary<int, string>();
        numMap.Add(2, "abc");
        numMap.Add(3, "def");
        numMap.Add(4, "ghi");
        numMap.Add(5, "jkl");
        numMap.Add(6, "mno");
        numMap.Add(7, "pqrs");
        numMap.Add(8, "tuv");
        numMap.Add(9, "qxyz");
        
        int n = digits.Length;
        List<string> result = new List<string>(); 
        findCombinations(digits, numMap, 0, n, result);   
        return result;
    }
        
    public void findCombinations(string digits, Dictionary<int, string> numMap, int index, int n, List<string> result){
        
        if(index == n){
            return;
        }
        
        int digit = Int32.Parse(digits[index].ToString());
        for(int i = 0; i<numMap[digit].Length; i++){
            result.Add(numMap[digit][i].ToString());
            findCombinations(digits, numMap, index+1,n, result);
        } 
    }
}
}