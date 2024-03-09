using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSenko.Basics
{
    internal class PrintInConsole : ICreateExample
    {
        public static void CreateExample()
        {

            /*----------------*/
            /*Print in Console*/
            /*----------------*/

            // The WriteLine method of the Console class is used to print to the console.

            // This method will print what is inside its parentheses on the console.
            // It will also give a line break automatically.

            Console.WriteLine( "Hello World" );

            // In addition to WriteLine there is the Write Method
            // Unlike WriteLine, Write will not give an automatic line break.
            // If not I would write next to the above

            Console.Write( "Hello" );
            Console.Write( " World\n" );

            /* Escape characters */

            // An escape character is a set of characters that have a special
            // meaning within a text or character string in programming.
            // These characters begin with a backslash followed by another character.

            /* Tab Character */
            Console.WriteLine( "Hello\tWorld" );

            /* backslash */
            Console.WriteLine( "Hello\\World" );

            /* Single quotation marks */
            Console.WriteLine( "Hello \'World\'" );

            /* Double quotation marks */
            Console.WriteLine( "Hello \"World\"" );

            /* Rewrite Character */
            Console.WriteLine( "Hello\rWorld" );

            /* Clear Character */
            Console.WriteLine( "Hello\bWorld" );

            /* New Line Character */
            Console.WriteLine( "Hello\nWorld" );

        }

    }

}
