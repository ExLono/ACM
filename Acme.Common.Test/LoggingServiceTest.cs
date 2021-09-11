using ACM.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Acme.Common.Test
{ 
    public class LoggingServiceTest
    {
    private readonly ITestOutputHelper _testOutputHelper;

    public LoggingServiceTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "aa@mail.ru",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);
            LoggingService.WriteToFile(changedItems);
            

        }
    }
}