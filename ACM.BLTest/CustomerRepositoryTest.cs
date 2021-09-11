using ACM.BL;
using System;
using Xunit;


namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "ada@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
            };

            var actual = customerRepository.Retrieve(1);
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName , actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

        }
    }
}
