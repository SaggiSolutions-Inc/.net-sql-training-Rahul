using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ScottObjects
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }

        public Course(int id, string courseName, string description, int credits)
        {
            Id = id;
            CourseName = courseName;
            Description = description;
            Credits = credits;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {CourseName},Description : {Description}, Credits: {Credits}" ;
        }
    }

}
