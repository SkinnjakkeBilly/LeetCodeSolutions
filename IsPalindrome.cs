namespace leetcode{
    public class IsPalindrome {
    public bool isPalindrome(int x) {
        bool isPal = false;
        string inn = x.ToString();
        int j = inn.Length-1;
        if(inn.Length==1){
            isPal = true;
        }else{
            for(int i = 0; i<inn.Length/2; i++){
            if(inn[i]==inn[j]){
                isPal = true;
            }else{
                return false;
            }
            j--;
        }
        }
        
        return isPal;
    }
}
}