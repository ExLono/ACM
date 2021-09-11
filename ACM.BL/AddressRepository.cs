using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine = "Bad End";
                address.City = "Hobbiton";
                address.Country = "Middle Earth";
                address.PostableCode = "141300";
            }
            return address;
        }

        public IEnumerable<Address> RetriveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine = "Bad End",
                City = "Hobbiton",
                Country = "Middle Earth",
                PostableCode = "141300",
            };

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine = "Green Dragon",
                City = "Bywater",
                Country = "Middle Earth",
                PostableCode = "141322",
            };

            return addressList;
        }
        public bool Save(Address address)
        {
            var success = true;
            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        //Вставка в память
                    }
                    else
                    {
                        //Обновить данные
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
