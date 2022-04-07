namespace HelloWorld
{

    public class Collection
    {
        public static void Arrays_MultiDimensional()
        {
            int[,] twoDArray = new int[2,3];
            int[,,] threeDarray = new int[3,3,3];
            int[][] jaggedArray = new int[2][];



        }

        public static int[] Reverse(int[] x)
        {
            //when called should print the elements of array in revers
            int[] reversed = new int[x.Length];

            for (int i=x.Length-1; i>=0; i--)
            {
                reversed[x.Length-i-1] = x[i];


            }
            return reversed;


        }

    }

}
