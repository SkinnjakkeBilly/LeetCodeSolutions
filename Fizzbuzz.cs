namespace leetcode
{
     class Fizzbuzz
    {
        public static void fizzbuzz()
        {
            List<String> list = new List<string>();
            for(int i = 1; i<100; i++)
            {
                String fizzbuzz = "";
                if(i%3==0){fizzbuzz+="Fizz";}
                if(i%5==0){fizzbuzz+="Buzz";}
                if(fizzbuzz==""){fizzbuzz= i.ToString();}
                list.Add(fizzbuzz);
            }
        }
    }
}
