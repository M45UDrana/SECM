using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            Address address = new Address(addressId);

            // Temporary hard-coded values to return 
            // a populated Address
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.streetLine1 = "Central Road";
                address.streetLine2 = "Vuter golli";
                address.City = "Dhaka";
                address.State = "Dhaka";
                address.Country = "Bangladesh";
                address.PostalCode = "122";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined address for the customer

            // Temporary hard-coded valus to return 
            // a set of address for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                streetLine1 = "Central Road",
                streetLine2 = "Vuter golli",
                City = "Dhaka",
                State = "Dhaka",
                Country = "Bangladesh",
                PostalCode = "1205"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                streetLine1 = "Central Road",
                streetLine2 = "Vuter golli",
                City = "Dhaka",
                State = "Dhaka",
                Country = "Bangladesh",
                PostalCode = "1205"
            };
            addressList.Add(address);

            address = new Address(3)
            {
                AddressType = 3,
                streetLine1 = "Central Road",
                streetLine2 = "Vuter golli",
                City = "Dhaka",
                State = "Dhaka",
                Country = "Bangladesh",
                PostalCode = "1205"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current Address
        /// </summary>
        /// <returns></returns>
        public bool Saves(Address address)
        {
            //Code that saves the passed address.

            return true;
        }
    }
}
