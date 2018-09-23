using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using EvenPlaning2.Data.DataModels;

namespace EvenPlaning2.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string EventModelId { get; set; }

        public EventModel EventModel { get; set; }

        public string EvenInfoId { get; set; }

        public EventInfo EventInfo { get; set; }
        
    }
}
