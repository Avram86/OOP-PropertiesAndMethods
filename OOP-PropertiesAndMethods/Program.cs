using System;

namespace OOP_PropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Name", "LastName");
            p.Print();

            p.ChangeIdentity("abc");
            p.Print();
        }
    }
}
