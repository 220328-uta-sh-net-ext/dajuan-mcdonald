namespace Arrays
{
    public class Array
    {
        public static void MoveZero(int[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                if(y[i] == 0)
                {
                    for (int j = i; j < y.Length-1; j++)
                    {
                        int temp = y[j];
                        y[j] = y[j+1];
                        y[j+1] = temp;

                    }
                    


                }

            }
            
        }

    }

    /*
     *
     *
     * Recap
Here's the most important things to remember when working with arrays.

An array is a special variable that holds a sequence of related data elements.
You should memorize the basic format of an array variable declaration.
Access each element of an array to set or get its values using a zero-based index inside of square brackets.
If you attempt to access an index outside of the boundary of the array, you'll get a run time exception.
The Length property gives you a programmatic way to determine the number of elements in an array.
     *
     *
     *
     * */

    /*
string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";


try {
    for (int i=0; i<fraudulentOrderIDs.Length; i++) 
    {

        Console.Write($@"{fraudulentOrderIDs[i]}\{fraudulentOrderIDs} ");

    } 

}
catch{
    

}
*/
}
