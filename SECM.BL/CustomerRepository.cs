using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepositories = new AddressRepository();
        }
        private AddressRepository addressRepositories { get; set; }
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create the instace of the customer class
            Customer customer = new Customer(customerId);

            // Temporary hard-coder values to return
            // a populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "masudranaata@gmail.com";
                customer.FirstName = "Masud";
                customer.LastName = "Rana";
                customer.AddressList = addressRepositories.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // Call an instance stored procedure
                    }
                    else
                    {
                        // call an update stored procedure
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
