using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects
{
    public abstract class Person 
    {
        public int Id { get; set; }
        public string FirstName { get;  set; }
        public string MiddleInitial { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }
        public string Phone { get;  set; }

        public Person(int id,string firstName, string middleInitial, string lastName, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            MiddleInitial = middleInitial;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
        public override string ToString()
        {
            return $"ID: {Id}, FirstName: {FirstName}, MiddleInitial: {MiddleInitial}, LastName: {LastName}, Email: {Email}, Phone: {Phone}";
        }
    }

}
