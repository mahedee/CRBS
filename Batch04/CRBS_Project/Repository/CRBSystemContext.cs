using CRBS_Project.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRBS_Project.Repository
{
    //public class CRBSystemContext : DbContext
    public class CRBSystemContext : IdentityDbContext<ApplicationUser>
    {
        //public CRBSystemContext() : base("name=DefaultConnection")
        //{

        //}
        public CRBSystemContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static CRBSystemContext Create()
        {
            return new CRBSystemContext();
        }

        
        public DbSet<ConferenceRoomInfoModels> ConferenceRoomInfoModels { get; set; } 
        public DbSet<BookingInfoModels> BookingInfoModels { get; set; }
        public DbSet<PropertyTypeInfo> PropertyTypeInfo { get; set; }
        public DbSet<GenderInfo> GenderInfo { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
    }
}