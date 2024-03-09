using System.Numerics;

namespace CodeWithSenko.DataStrucs
{
    internal class CWSArrays : ICreateExample
    {

        public static void PrintArray( Array array )
        {

            Console.Write( "[" );

            for (int i = 0; i < array.Length; i++ )
                Console.Write( i < array.Length ? array.GetValue( i ) + ", " : array.GetValue( i ) );

            Console.WriteLine( "]" );

        }

        public static void PrintArray( String msg, Array array )
        {

            Console.Write( msg );

            PrintArray( array );

        }

        public static void CreateExample()
        {
            /* Create Arrays */

            string[] strings = new string[3];

            int[] ints = new int[3];

            bool[] bools = new bool[3];

            float[] floats = new float[3];

            double[] doubles = new double[3];

            decimal[] decimals = new decimal[3];

            Structs.Vector[] vectors = new Structs.Vector[3];

            OOP.Employee[] employees = new OOP.Employee[3];

            Array[] arrays = new Array[3];

            /* Access to the elements of an Array */

            // print 0
            Console.WriteLine( ints[0] );

            /* Declare elements in an Array */

            string[] names = new string[3];

            names[0] = "Senko";
            names[1] = "Freddy";
            names[2] = "Hitori";

            string[] lastNames = { "San", "Fazbear", "Gotoh" };

            /*----------------*/
            /* Type of Arrays */
            /*----------------*/

            /* Multidimensional Arrays */
            string[,] array2D =
            {
                { "Senko", "Freddy", "Hitori" },
                { "San", "Fazbear", "Gotoh" }
            };

            int[,,] array3D =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                {
                    { 10, 11, 12 },
                    { 13, 14, 15 },
                    { 16, 17, 18 }
                },
                {
                    { 19, 20, 21 },
                    { 22, 23, 24 },
                    { 25, 26, 27 }
                }
            };

            /* Accessing a Multidimensional Array elements */

            Console.WriteLine( "Multidimensional Arrrays" );

            // print "Fazbear"
            Console.WriteLine( "array2D: {0}", array2D[0, 1] );

            // print 18
            Console.WriteLine( "array3D: {0}", array3D[1, 2, 2] );

            Console.WriteLine();

            /*---------------*/
            /* Jagged Arrays */
            /*---------------*/

            int[][] jaggedInts = new int[3][];

            jaggedInts[0] = new int[3] { 1, 2, 3 };
            jaggedInts[1] = new int[3] { 4, 5, 6 };
            jaggedInts[2] = new int[3] { 7, 8, 9 };

            int[][] jaggedInts2 =
            {
                new int[3] { 1, 2, 3 },
                new int[3] { 4, 5, 6 },
                new int[3] { 7, 8, 9 }
            };

            /* Accesing a Jagged Array elements */

            Console.WriteLine( "Jagged Arrays:" );

            // Both prints 6
            Console.WriteLine( "JaggedInt: {0}", jaggedInts[1][2] );
            Console.WriteLine( "JaggedInt2: {0}", jaggedInts2[1][2] );

            /*------------------*/
            /* Arrays of Arrays */
            /*------------------*/

            Array[] arrayOfArrays = new Array[5]
            {
                new string[3] { "Senko", "Freddy", "Hitori"},
                new int[3] { 1, 2 ,3 },
                new Structs.Vector[3],
                new int[2,3] {{ 1, 2, 3 }, { 4, 5, 6} },
                new OOP.Employee[2][] { new OOP.Employee[2], new OOP.Employee[2] }
            };

        }

    }
}
