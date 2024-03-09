using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSenko.DataStrucs
{
    internal class CWSLists : ICreateExample
    {

        public static void PrintList<T>( String msg, List<T> list )
        {

            Console.Write( "{0} Count: {1} Capacity: {2}\n", msg, list.Count, list.Capacity );

            CWSArrays.PrintArray( "  ", list.ToArray() );

        }

        public static void CreateExample()
        {

            Index();

            ListMethods();

        }

        static void Index()
        {

            /* Constructors */

            // List<T>()
            // Creates an empty list with the determined capacity (0)
            List<int> list1 = new List<int>();

            // List<T>(IEnumerable<T>)
            // Creates a List with items copied from a collection and a capacity
            // of the same length as the collection.
            int[] numbers = { 1, 2, 3 };

            List<int> list2 = new List<int>(numbers);

            // List<T>(Int32)
            // Creates an empty List with a specified capacity
            List<int> list3 = new List<int>(5);

            // This Print the List
            PrintList( "List1", list1 );

            // Adding elements to the List
            list1.Add( 1 );
            list1.Add( 5 );
            list1.Add( 1 );
            list1.Add( 1 );
            list1.Add( 2 );
            list1.Add( 3 );

            PrintList( "List1", list1 );

            // Adding elements to the List in his construction
            List<string> heavyThings = new List<string>
            {
                "Black Hole",
                "The Sun",
                "Your Mom"
            };

            PrintList( "Heavy Things:", heavyThings );

        }

        static void ListMethods()
        {

            /*---------------*/
            /* Lists Methods */
            /*---------------*/

            List<string> names = new List<string>
            {
                "Senko San",
                "Freddy Fazbear",
                "Clancy"
            };

            /* Add Methods */

            // List<T>.Add(T)
            names.Add( "Intruder" );

            PrintList( "Names after add \"Intruder\"", names );

            // List<T>.AddRange(IEnumerable<T>)
            String[] newNames = { "Hitori Gotoh", "Rick Sanchez" };

            names.AddRange( newNames );
            names.AddRange( new String[] { "Morty Smith", "Shiro" } );

            PrintList( "Names after AddRange:", names );

            /* Insert Methods */

            // List<T>.Insert(Int32, T)
            names.Insert( 1, "WAOS" );

            // List<T>.InsertRange(Int32, IEnumerable<T>)
            names.InsertRange( 1, new string[] { "Miku", "Nijika" } );

            /* Remove Methods */

            PrintList( "Names List", names );

            // List<T>.Remove(T)
            Console.WriteLine( names.Remove( "WAOS" ) );

            PrintList( "Remove WAOS", names );

            // List<T>.RemoveAt(Int32)
            names.RemoveAt( 3 );

            PrintList( "Remove element from index 3", names );

            // List<T>.RemoveRange(Int32, Int32)
            names.RemoveRange( 1, 3 );

            PrintList( "Remove element from index 1 to 3", names );

            // List<T>.RemoveAll(Predicate<T>)
            // Remove all elements can contains letter u or i
            names.RemoveAll( x => x.Contains( 'u' ) || x.Contains( 'i' ) );

            PrintList( "Remove all elements with 'u' || 'i'", names );

            /*---------------------------------------------*/

            // List<T>.Contains(T)
            Console.Write( "Names contains \"Senko San\"?: " );
            Console.Write( "{0}\n", names.Contains( "Senko San" ) );

            /* Find Methods */

            // List<T>.Find(Predicate<T>)
            Console.WriteLine("First name with letter 'e': {0}", names.Find(x => x.Contains('e')));

            // List<T>.FindAll(Predicate<T>)
            PrintList("All names with letter 'i': {0}", names.FindAll(x => x.Contains('i')));

            // List<T>.FindLast(Predicate<T>)
            Console.WriteLine("Last name with letter 'e': {0}\n", names.FindLast(x => x.Contains('e')));

            // List<T>.FindIndex(Predicate<T>)
            Console.Write("Index of the first element with letter 'y':");
            Console.Write(names.FindIndex(x => x.Contains('y')) + "\n");

            // List<T>.FindIndex(Predicate<T>)
            Console.Write("Index of the last element with letter 'y':");
            Console.Write(names.FindLastIndex(x => x.Contains('y')) + "\n");

            /* ToArray */

            Array namesArr = names.ToArray();

            CWSArrays.PrintArray( "List To Array", namesArr );

            /* ForEach */

            // For this example we will create a new List
            List<int> ints = new List<int>() {1, 2, 3, 4, 5, 6, 7};

            // Prints all numbers
            ints.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            // Square and print
            ints.ForEach( i =>
            {
                i = (int)Math.Pow(i, 2);
                Console.Write( i + " " );
            } );
            Console.WriteLine();

            // print odd or even
            ints.ForEach( i =>
            {
                if ( i % 2 == 0 )
                    Console.WriteLine( "Even" );
                else
                    Console.WriteLine( "Odd" );
            } );

            /* Exists */

            Console.Write( "Name with a length greater than 5: " );
            Console.WriteLine( names.Exists( x => x.Length > 5 ) );

            Console.Write( "Name beginning with \"Cl\": " );
            Console.WriteLine( names.Exists( x => x.StartsWith( "Cl" ) ) );

            /* Slice */

            List<String> names2 = names.Slice(0, 3);

            PrintList( "names2", names2 );
            PrintList( "Original", names );

            /* Clear */
            names.Clear();

            PrintList( "After Clear method", names );

        }

        static void ListProperties()
        {

        }

    }

}
