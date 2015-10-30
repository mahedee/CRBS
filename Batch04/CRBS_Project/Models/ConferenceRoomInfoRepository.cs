using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBS_Project.Models
{
    public class ConferenceRoomInfoRepository
    {
        public List<ConferenceRoomInfoModels> GetConferenceRoomInfo()
        {

            List<ConferenceRoomInfoModels> lstConferenceRoomInfo = new List<ConferenceRoomInfoModels>() 
            { 
                new ConferenceRoomInfoModels 
                { 
                    PropertyId = 1, 
                    PropertyName = "Pan pacific Sonaragaon", 
                    PersonCapacity = 50, 
                    PropertyPurposeId = 1, 
                    RoomTypeId = 1, 
                    FairAmount = 15000
                }, 
                new ConferenceRoomInfoModels 
                { 
                    PropertyId = 2, 
                    PropertyName = "Sonaragaon", 
                    //PropertyName ="<script>alert('Your password is: abcd');</script>",
                    PersonCapacity = 40, 
                    PropertyPurposeId = 1, 
                    RoomTypeId = 1, 
                    FairAmount = 15000
 
                }, 
                new ConferenceRoomInfoModels 
                { 
                     PropertyId = 3, 
                    PropertyName = "Pan Sonaragaon", 
                    PersonCapacity = 150, 
                    PropertyPurposeId = 1, 
                    RoomTypeId = 1, 
                    FairAmount = 15000
                }, 
                 
                new ConferenceRoomInfoModels 
                { 
                     PropertyId = 4, 
                    PropertyName = "Others", 
                    PersonCapacity = 50, 
                    PropertyPurposeId = 1, 
                    RoomTypeId = 1, 
                    FairAmount = 15000
                } 
            };

            return lstConferenceRoomInfo;
        }
    }
}