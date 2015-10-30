using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBS_Project.Models
{
    public class Dashboard
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public int PersonCapacity { get; set; }
        public int PropertyPurposeId { get; set; }
        public string PropertyPurposeName { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public int FairAmount { get; set; }

    }
}