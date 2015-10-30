using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRBS_Project.Models
{
    [Table("BookingInfo")]
    public class BookingInfoModels
    {
        [Key]
        public string BookingId { get; set; }
        public int PropertyId { get; set; }
        [ForeignKey("PropertyId")]
        public virtual ConferenceRoomInfoModels ConferenceRoomInfoModels { get; set; } 
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string BookingStatus { get; set; }
        public string StatusName { get; set; }

    }
}