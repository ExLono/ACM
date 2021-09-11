using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        //Вернуть покупателя по id
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if(customerId==1)
            {
                customer.EmailAddress = "ada@gmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetriveByCustomerId(
                    customerId).ToList();
            }

            return customer;
        }
        //Вернуть список всех покупателей
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        //Сохранение?
        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
