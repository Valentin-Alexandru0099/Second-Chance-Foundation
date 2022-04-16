using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PaymentsController : BaseApiController
    {
        private readonly PaymentService _paymentService;
        public PaymentsController(PaymentService paymentService)
        {
            _paymentService = paymentService;
            
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<DonationDto>> CreateOrUpdatePaymentIntent()
        {
            var donation = new Donation{Amount = 100};

            var intent = await _paymentService.CreatePaymentIntent(donation);

            if (intent == null) return BadRequest(new ProblemDetails{Title = "Problem creating payment intent"});

            //?? - if null
            donation.PaymentIntentId = donation.PaymentIntentId ?? intent.Id;
            donation.ClientSecret = donation.ClientSecret ?? intent.ClientSecret;

            return donation.MapDonationToDto();
        }
        
    }
}