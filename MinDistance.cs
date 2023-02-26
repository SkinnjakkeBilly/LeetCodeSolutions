namespace leetcode{
    public class MinDistance {
    public static int minDistance(string word1, string word2) {
//Denne sjekker ikke minimum distanse, men teller bare antall operasjoner for å switche, så løsningen er feil.
        char[] w1 = new char[word2.Length];

        int max = Math.Max(word1.Length, word2.Length);
        int min = Math.Min(word1.Length, word2.Length);
        //sjekker diffen i lengde, det er antallet som må legges til eller slettes.
        int op = max-min;
        //int op = Math.Abs(word2.Length-word1.Length);
        for(int i = 0; i<word2.Length; i++){
            if(word1[i]==word2[i]){
                w1[i]=word2[i];
            }else{
                w1[i]=word2[i];
                op++;
            }
        }
        string wordString = new string(w1);
        Console.WriteLine(wordString);
        Console.WriteLine("operations: "+ op);
        return op;
    }
   
}
}