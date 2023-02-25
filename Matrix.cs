namespace leetcode{
    class Matrix{
        public static void matrix(){
            //{{1,2,3,4},{5,6,7,8},{9,10,11,12}}
            int[][] m = {new int[]{1,2,3,4},new int[]{5,6,7,8}, new int[]{9,10,11,12}};
            List<int> steike = (List<int>)SpiralOrder(m);
            foreach(int s in steike){
                Console.Write (s + " ");
            }
        }
        public static IList<int> SpiralOrder(int[][] matrix) 
        {
        List<int> ret = new List<int>();

        int startrad = 0;
        int startkol = 0;
        int sluttrad = matrix.Length-1;
        int sluttkol = matrix[0].Length-1;

        while(startrad<=sluttrad && startkol <= sluttkol)
        {

            //øverst
            for(int j = startkol; j<=sluttkol; j++){
                ret.Add(matrix[startrad][j]);
            }
            startrad++;

            //endekolonne
            for(int j = startrad; j<=sluttrad; j++){
                ret.Add(matrix[j][sluttkol]);
            }
            sluttkol--;

            //nederst
            if (startrad <= sluttrad) {
                for(int j = sluttkol; j>=startkol; j--){
                    ret.Add(matrix[sluttrad][j]);
                }
            }
            sluttrad--;

            //førstekolonne
            if(startkol <= sluttkol){
                for(int j = sluttrad; j>=startrad; j--){
                    ret.Add(matrix[j][startkol]);
                }
            }
            startkol++;

        }
        return ret;
    }
    }

}
