using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ScottObjects;

namespace ScottObjects
{
    public class Student : Person
    {
        //public int Id { get; set; }
        public DateTime? DateOfBirth { get;  set; }

        public Student(int id, string firstName, string middleInitial, string lastName, string email, string phone, DateTime? dob)
            : base(id,firstName, middleInitial, lastName, email, phone)
        {
            //Id = id;
            DateOfBirth = dob;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {FirstName} {MiddleInitial} {LastName}, Email: {Email}, Phone: {Phone}, Date of Birth: {DateOfBirth?.ToString("yyyy-MM-dd") ?? "Not Available"}";
        }



        // New Method to Print Only the Date
        public void PrintDateOfBirth()
            {
                if (DateOfBirth.HasValue)
                {
                    Console.WriteLine($"Date of Birth: {DateOfBirth.Value.ToString("YYYY-MM-dd")}");
                }
                else
                {
                    Console.WriteLine("Date of Birth: Not Available");
                }
            }
        }


    }





