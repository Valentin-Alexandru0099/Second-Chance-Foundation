using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.Extensions.Configuration;
using Stripe;

namespace API.Services
{
    public class PaymentService
    {
        private readonly IConfiguration _config;
        public PaymentService(IConfiguration config)
        {
            _config = config;
            
        }

        public async Task<PaymentIntent> CreatePaymentIntent(Donation donation)
        {
            StripeConfiguration.ApiKey = _config["StripeSettings:SecretKey"];

            var service = new PaymentIntentService();

            var intent = new PaymentIntent();

            var donationAmount = donation.Amount;

            var options = new PaymentIntentCreateOptions
            {
                Amount = donationAmount,
                Currency = "USD",
                PaymentMethodTypes = new List<string> {"card"}
            };
            intent = await service.CreateAsync(options);
            return intent;
        }
    }
}