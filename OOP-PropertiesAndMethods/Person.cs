using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PropertiesAndMethods
{
    public class Person
    {
        private string firstName;
        public string FirstName
        {
            //accesori

            get
            {
                //cand cineva incearca sa citeasca proprietatea
                Console.WriteLine("Executing FirtsName.get");

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    //valoare de default
                    firstName = "Test firstName";
                }

                return firstName;
            }
            set
            {
                //cand cineva incearca sa scrie proprietatea
                Console.WriteLine("Executing FirtsName.set");

                if (string.IsNullOrEmpty(value))
                {
                    value = "default FirstName";
                }

                firstName = value;
            }
        }

        public void Print() 
        {
            Console.WriteLine($"Person's first name {FirstName}");
        }

    }
}
