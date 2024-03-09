using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSenko.OOP
{
    internal class ClassDeclaration
    {

        public static void CreateExample()
        {

            // Instance/Object
            User newUser = new User("Senko", "San", 800);

            Console.WriteLine( newUser );

            Console.WriteLine( newUser.GetName );

        }

    }

    // Class Declaration
    class User
    {
        /* Getter And Setter */

        // Getters
        public String GetName => _firstName + " " + _lastName;
        public int GetAge => _age;

        // Setters
        public String SetFirstName { set { _firstName = value; } }
        public String SetLastName { set { _lastName = value; } }
        public int SetAge { set { _age = value; } }

        // Getter and setter
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        /* Class Constructors */

        // Default Constructor
        public User() { }

        public User( string firstName, string lastName, int age )
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        /* Methods in a Class */
        public void SayHello() => Console.WriteLine( "Hiiiiiii" );

        // Class Properties
        private String _firstName, _lastName;

        private int _age;

    }
}
