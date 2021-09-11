using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostableCode { get; set; }
        public string StreetLine { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (PostableCode == null)
                isValid = false;
            return isValid;
        }
    }
}
