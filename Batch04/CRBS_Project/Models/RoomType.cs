using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRBS_Project.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public ICollection<ConferenceRoomInfoModels> ConferenceRoomInfoModels { get; set; }
    }
}