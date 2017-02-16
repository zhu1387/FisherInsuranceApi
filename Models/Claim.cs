using System;
namespace FisherInsuranceApi.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string ProductNumber { get; set; }
        public DateTime LossDate { get; set; }       
        public decimal LossAmount {get; set; }
        public string Status { get; set; }
    }
}