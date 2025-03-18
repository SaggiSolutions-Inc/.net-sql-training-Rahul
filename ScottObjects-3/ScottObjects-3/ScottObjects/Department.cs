using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects
{
    public class Department 
    {
        public int Id { get; set; } 
        public string DName { get;  set; } 
        public string Loc { get;  set; } 

        public Department(int id, string dName, string loc)
        {
            Id = id;
            DName = dName;
            Loc = loc;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {DName}, Code: {Loc}";
        }

    }

}
