using Data.Core.Models;
using System;
using System.Collections.Generic;

namespace TravelExperts.Controllers
{
    public class BookingDetailViewModel
    {

        public DateTime? BookingDate { get; set; }

        public string BookingNo { get; set; }

        public double? TravelerCount { get; set; }

        public int? CustomerId { get; set; }

        public string TripTypeId { get; set; }

        public int? PackageId { get; set; }

        public int BookingDetailId { get; set; }

        public double? ItineraryNo { get; set; }

        public DateTime? TripStart { get; set; }

        public DateTime? TripEnd { get; set; }

        public string Description { get; set; }

        public string Destination { get; set; }

        public decimal? BasePrice { get; set; }


        public decimal? AgencyCommission { get; set; }

        public int? BookDetId { get; set; }

        
        public string RegionId { get; set; }

        
        public string ClassId { get; set; }

        public string FeeId { get; set; }

        public int? ProductSupplierId { get; set; }

        public List<TripType> TripTypes { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Class Class { get; set; }

        public virtual Fee Fee { get; set; }

        public virtual Products_Suppliers Products_Suppliers { get; set; }

        public virtual Region Region { get; set; }

        public List<BookingDetail> BookingDetails { get; set; }
    }
}