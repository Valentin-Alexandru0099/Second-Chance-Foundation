using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Extensions
{
    public static class DonationExtension
    {
        public static DonationDto MapDonationToDto(this Donation donation)
        {
            return new DonationDto
            {
                Amount = donation.Amount,
            };
        }
    }
}