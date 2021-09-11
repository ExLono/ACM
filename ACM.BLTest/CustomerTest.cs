using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Dmitriy",
                LastName = "Fedin"
            };
            string expected = "Fedin, Dmitriy";
            string actual = customer.FullName;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Fedin"
            };

            string expected = "Fedin";
            string actual = customer.FullName;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            var c1 = new Customer
            {
                LastName = "Bilbo",
                EmailAddress = "aere@gmail.com"
            };
            var expected = true;
            var actual = c1.Validate();
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ValidateMissLastName()
        {
            var c1 = new Customer
            {
                EmailAddress = "aere@gmail.com"
            };
            var expected = false;
            var actual = c1.Validate();
            Assert.Equal(expected, actual);

        }
    }
}
