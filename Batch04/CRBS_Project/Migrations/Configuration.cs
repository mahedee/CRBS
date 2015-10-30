namespace CRBS_Project.Migrations
{
    using CRBS_Project.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRBS_Project.Repository.CRBSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRBS_Project.Repository.CRBSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Restaurants.AddOrUpdate(r => r.Name,
            context.GenderInfo.AddOrUpdate(r => r.GenderId,
                new GenderInfo
                {
                    GenderId = 1,
                    GenderName = "Male"
                },
                new GenderInfo
                {
                    GenderId = 2,
                    GenderName = "Female"
                },
                new GenderInfo
                {
                    GenderId = 3,
                    GenderName = "Others"
                });

            context.PropertyTypeInfo.AddOrUpdate(r => r.PropertyPurposeId,
                new PropertyTypeInfo
                {
                    PropertyPurposeId = 1,
                    PropertyPurposeName = "Meeting or Conference"
                },
                 new PropertyTypeInfo
                {
                    PropertyPurposeId = 2,
                    PropertyPurposeName = "Festival Party"
                });

            context.RoomType.AddOrUpdate(r => r.RoomTypeId,
               new RoomType
               {
                   RoomTypeId = 1,
                   RoomTypeName = "AC"
               },
                new RoomType
                {
                    RoomTypeId = 2,
                    RoomTypeName = "Non-AC"
                });

            context.ConferenceRoomInfoModels.AddOrUpdate(r => r.PropertyId,
               new ConferenceRoomInfoModels
               {
                   PropertyName = "Hotel Westing",
                   PersonCapacity = 50,
                   PropertyPurposeId = 1,
                   RoomTypeId = 1,
                   FairAmount = 20000
               });

        }
    }
}
