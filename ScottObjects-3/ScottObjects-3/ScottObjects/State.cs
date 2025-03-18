using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects
{
    public class State 
    {
        public  int Id { get; set; }
        public string StateName { get;  set; }
        public string StateCode { get;  set; }

        public State(int id, string stateName, string stateCode)
        {
            Id = id;
            StateName = stateName;
            StateCode = stateCode;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {StateName}, Code: {StateCode}";
        }
    }

}
