using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRBS_Project.Models
{
    public class PropertyTypeInfo
    {
        [Key]
        public int PropertyPurposeId { get; set; }
        public string PropertyPurposeName { get; set; }
        public ICollection<ConferenceRoomInfoModels> ConferenceRoomInfoModels { get; set; }
    }
}