using EvenPlaning2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvenPlaning2.Data.DataModels
{
    public class EventInfo
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime DateEvent { get; set; }

        public string Location { get; set; }

        public string DressCode { get; set; }

        public List<ApplicationUser> Participants { get; set; }

        public string EventModelId { get; set; }

        public EventModel EventModel { get; set; }
    }
}
