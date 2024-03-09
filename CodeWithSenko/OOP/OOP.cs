using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWithSenko.OOP
{
    public class Employee
    {

        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string Name => _firstName + " " + _lastName;

        public Employee( string firstName, string lastName )
        {

            _firstName = firstName;
            _lastName = lastName;

        }

        public virtual void Work() => Console.WriteLine( "{0} is working", _firstName );

        private string _firstName, _lastName;
    }

    public class Boss : Employee
    {

        public string? Departament => _departament;

        public Boss( string firstName, string lastName, string departament )
            : base( firstName, lastName )
        {

            _departament = departament;

        }

        public Boss( string firstName, string lastName ) : base( firstName, lastName ) { }

        public override void Work() => Console.WriteLine( "{0} is managing", FirstName );

        private string? _departament;
    }

    public class CEO : Boss
    {

        public string Company => _company;

        public CEO( string firstName, string lastName, string company ) : base( firstName, lastName )
        {

            _company = company;

        }

        public override void Work() => Console.WriteLine( "{0} is making descisions", FirstName );

        private string _company;
    }
}
