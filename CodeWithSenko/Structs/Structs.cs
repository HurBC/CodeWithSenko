using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSenko.Structs
{
    public struct Vector
    {
        public int X, Y;

        public Vector( int x, int y )
        {
            X = x;
            Y = y;
        }
    }

    class Player
    {
        public int PositionX, PositionY;

        public Player( int x, int y )
        {
            PositionX = x;
            PositionY = y;
        }
    }

    internal class Structs
    {
        public static void CreateExample()
        {

            Vector v1 = new Vector(9, 11);
            Vector v2 = v1;

            Console.WriteLine( "Type Value VS Type Reference\n" );
            Console.WriteLine( "Type Value:" );
            Console.WriteLine( "Before changing X" );
            Console.WriteLine( "v1: {0}\nv2: {1}\n", v1.X, v2.X );

            v2.X = 10;

            Console.WriteLine( "After changing X" );
            Console.WriteLine( "v1: {0}\nv2: {1}\n", v1.X, v2.X );

            Console.WriteLine( "Type Reference:" );

            Player p1 = new Player(27, 2);
            Player p2 = p1;

            Console.WriteLine( "Before changing X" );
            Console.WriteLine( "p1: {0}\np2: {1}\n", p1.PositionX, p2.PositionX );

            p2.PositionX = 0;

            Console.WriteLine( "After changing X" );
            Console.WriteLine( "p1: {0}\np2: {1}\n", p1.PositionX, p2.PositionX );
        }
    }
}
