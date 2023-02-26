namespace leetcode{
public class ValidParenthesis {
    public bool validParenthesis(string s) {
        Stack<char> stack = new Stack<char>();
        //bool valid = false;
        for(int i = 0; i<s.Length; i++){
            switch(s[i]){
                case '(':
                case '{':
                case '[':
                    stack.Push(s[i]);
                    break;
                case ')':
                    if(!(stack.Count>0) || stack.Pop() != '(')
                    {
                        return false;
                    }
                    break;
                case '}':
                    if(!(stack.Count>0) || stack.Pop() != '{')
                    {
                        return false;
                    }
                    break;
                case ']':
                    if(!(stack.Count>0) || stack.Pop() != '[')
                    {
                        return false;
                    }
                    break;

            }
           
            
        }
        if(stack.Count>0){
            return false;
        }else{
            return true;
        }
        
    }
}
}