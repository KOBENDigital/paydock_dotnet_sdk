﻿using NUnit.Framework;
using Paydock_dotnet_sdk.Services;
using Paydock_dotnet_sdk.Models;

namespace FunctionalTests
{
    [TestFixture]
    public class CustomerServiceTests
    {
        string secretKey = "fccbf57c8a65a609ed86edd417177905bfd5a99b";
        string gatewayId = "58377235377aea03343240cc";

        [SetUp]
        public void Init()
        {
            Config.Initialise(Environment.Sandbox, secretKey);
        }

        [Test]
        public void CreateCustomerWithCreditCard()
        {
            var request = new CustomerRequest
            {
                first_name = "john",
                last_name = "smith",
                payment_source = new PaymentSource
                {
                    gateway_id = gatewayId,
                    card_name = "John Smith",
                    card_number = "4111111111111111",
                    card_ccv = "123",
                    expire_month = "10",
                    expire_year = "2020"
                }
            };

            var result = new Customers().Add(request);

            Assert.IsTrue(result.IsSuccess);
        }
    }
}
