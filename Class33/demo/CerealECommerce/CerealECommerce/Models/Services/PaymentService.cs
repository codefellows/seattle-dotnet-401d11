using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;
using AuthorizeNet.Utility;
using CerealECommerce.Models.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CerealECommerce.Models.Services
{
    public class PaymentService : IPayment
    {
        private IConfiguration _config;

        public PaymentService(IConfiguration configuration)
        {
            _config = configuration;
        }
        public string Run()
        {
            // decalred the type of environment
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            // setup our merchant account credentials
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new AuthorizeNet.Api.Contracts.V1.merchantAuthenticationType()
            {
                name = _config["AuthorizeLoginid"],
                ItemElementName = ItemChoiceType.transactionKey,
                Item = _config["AuthorizeTransactionKey"]
            };

            // create the card we want on file.
            // I want you to store these in your secrets file, adn choose a dropdown for the user in the checkout process

            var creditCard = new creditCardType
            {
                cardNumber = "4111111111111111",
                expirationDate = "1020",
                cardCode = "555"
            };

            customerAddressType billingAddress = GetsBillingAddress(3);

            //declare that thuse is going to use an existing Credit Cart to pay
            var paymentType = new paymentType { Item = creditCard };

            // // make the transactionRequest

            var transRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),
                amount = 150.75m,
                payment = paymentType,
                billTo = billingAddress
            };

            // made teh transaction type, now we need to make the request
            var request = new createTransactionRequest { transactionRequest = transRequest };

            var controller = new createTransactionController(request);
            controller.Execute();

            var response = controller.GetApiResponse();


            return "";
        }

        private customerAddressType GetsBillingAddress(int orderId)
        {
            // you can pull this data from teh db the individual data from the order/cart itself
            customerAddressType address = new customerAddressType
            {
                firstName = "Josie",
                lastName = "Kitty",
                address = "123 Cat Nip Lane",
                city = "Seattle",
                zip = "98004"
            };

            return address;
        }

    }
}
