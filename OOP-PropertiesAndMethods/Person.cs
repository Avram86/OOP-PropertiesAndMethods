using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PropertiesAndMethods
{
    public class Person
    {
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        private string _firstName;
        public string FirstName
        {
            //accesori

            get
            {
                //cand cineva incearca sa citeasca proprietatea
                Console.WriteLine("Executing FirtsName.get");

                return string.IsNullOrEmpty(_firstName) ? "Test FirstName" : _firstName;
                
            }
            //sa se poata scrie doar din interiorul clasei
            //private set
            //{
            //    //cand cineva incearca sa scrie proprietatea
            //    Console.WriteLine("Executing FirtsName.set");

            //    firstName = value ?? string.Empty;
            //}
        }

        //properietati auto-implementate
        public string LastName{ get; }

        //poate fi setata doar in constructor
        //este un read-only
        //nu STATIC!!!!
        //obiectul devine imutabil
        public string Name { get; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public void ChangeIdentity(string firstName)
        {
            _firstName = firstName ?? string.Empty;
        }

        public void Print() 
        {
            Console.WriteLine($"Person's first name {FirstName}");
        }

    }
}
