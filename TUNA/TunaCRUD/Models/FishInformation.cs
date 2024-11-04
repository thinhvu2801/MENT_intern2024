using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TunaCRUD.Models
{
    public class FishInformation
    {
        [Key]
        public string FishNumber { get; set; }
        public string GRNNumber { get; set; }
        public string CatchingMethod { get; set; }
        public string CatchArea { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime CatchDate { get; set; }
        public string Species { get; set; }
        public string CollectedBy { get; set; }
        public string ReceivedFor { get; set; }
        public string NIC { get; set; }
        public string Grade { get; set; }
        public string Vessel { get; set; }
        public string DhoniCode { get; set; }
        public decimal Weight { get; set; }

    }

    
}
