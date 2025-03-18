using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects
{
    public class Address 
    {
        public int Id { get; set; }
        public string AddressLine1 { get;  set; }
        public string AddressLine2 { get;  set; }
        public string City { get;  set; }
        public int StateId { get;  set; }
        public string ZipCode { get;  set; }
        public char EntityType { get;  set; } 
        public int EntityId { get;  set; }

        public Address(int id, string addressLine1, string addressLine2, string city, int stateId, string zipCode, char entityType, int entityId)
        {
            Id = id;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            StateId = stateId;
            ZipCode = zipCode;
            EntityType = entityType;
            EntityId = entityId;
        }
    }
}
