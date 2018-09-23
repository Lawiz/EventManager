using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EvenPlaning2.Data.DataModels;

namespace EvenPlaning2.Data.DataModels
{
    public class SubThem
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string SubThemValue { get; set; }

        public string EventModelId { get; set; }

        public EventModel EventModel { get; set; }



    }
}
