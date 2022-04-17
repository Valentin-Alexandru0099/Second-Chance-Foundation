//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using API.Data;
//using API.DTOs;
//using API.Entities;
//using API.Extensions;
//using API.Services;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace API.Controllers
//{
//    public class PaymentsController : BaseApiController
//    { 
//        private readonly PaymentService _paymentService;
//        public PaymentsController(PaymentService paymentService)
//        {
//            _paymentService = paymentService;

//        }

//        [Authorize]
//        [HttpPost]
//        public async Task<ActionResult<DonationDto>> CreateOrUpdatePaymentIntent(Donation donation)
//        {


//            var intent = await _paymentService.CreatePaymentIntent(donation);

//            if (intent == null) return BadRequest(new ProblemDetails{Title = "Problem creating payment intent"});

//            //?? - if null
//            donation.PaymentIntentId = donation.PaymentIntentId ?? intent.Id;
//            donation.ClientSecret = donation.ClientSecret ?? intent.ClientSecret;

//            return donation.MapDonationToDto();
//        }

//        [HttpGet]
//        public async Task<ActionResult<string>> GetClientSecret()
//        {
//            var donation = new Donation { Amount = 100 };
//            return donation.ClientSecret;
//        }



//    }
//}


using System;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace API.Controllers
{
    [Route("payments")]
    [ApiController]
    public class PaymentsController : Controller
    {

        private readonly PaymentService _paymentService;
        public PaymentsController(PaymentService paymentService)
        {
            _paymentService = paymentService;

        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var donation = new Donation { Amount = 100 };
            var intent = await _paymentService.CreatePaymentIntent(donation);
            return Json(new { client_secret = intent.ClientSecret });
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<DonationDto>> CreateOrUpdatePaymentIntent(Donation donation)
        {


            var intent = await _paymentService.CreatePaymentIntent(donation);

            if (intent == null) return BadRequest(new ProblemDetails { Title = "Problem creating payment intent" });

            //?? - if null
            donation.PaymentIntentId = donation.PaymentIntentId ?? intent.Id;
            donation.ClientSecret = donation.ClientSecret ?? intent.ClientSecret;

            return donation.MapDonationToDto();
        }
    }
}