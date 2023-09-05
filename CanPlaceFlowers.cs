namespace leetcode{
public class Flowerbed {
    public static bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        for(int i = 0; i<flowerbed.Length; i++){
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i-1] == 0) && (i == flowerbed.Length-1 || flowerbed[i+1] == 0)) {
                count++;
                flowerbed[i]=1;
            }

        }
        if(n<=count){
            return true;
        }
        return false;
    }
}
}
