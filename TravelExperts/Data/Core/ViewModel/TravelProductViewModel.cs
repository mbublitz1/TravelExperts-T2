using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;

namespace Data.Core.ViewModel
{
    public class TravelProductViewModel
    {
        public int CustomerId { get; set; }
        public string CustFirstName { get; set; }

        public string CustLastName { get; set; }
        public string UserId { get; set; }

        public List<Booking> Bookings { get; set; }


        //public int PackageId { get; set; }
        //public string PkgDesc { get; set; }
        //public decimal PkgBasePrice { get; set; }
        //public decimal? PkgAgencyCommission { get; set; }
        //public double? TravelerCount { get; set; }

    }
}
