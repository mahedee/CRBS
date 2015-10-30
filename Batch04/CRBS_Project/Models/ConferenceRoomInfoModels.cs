using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRBS_Project.Models
{
    [Table("ConferenceRoomInfo")]
    public class ConferenceRoomInfoModels
    {
        [Key]
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public int PersonCapacity { get; set; }
        public int PropertyPurposeId { get; set; }
        [ForeignKey("PropertyPurposeId")]
        public virtual PropertyTypeInfo PropertyTypeInfo { get; set; }
        public int RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        public virtual RoomType RoomType { get; set; }
        public int FairAmount { get; set; }

        public ICollection<BookingInfoModels> BookingInfoModels { get; set; }
    }
}