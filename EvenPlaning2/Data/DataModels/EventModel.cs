using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EvenPlaning2.Data.DataModels;
using EvenPlaning2.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvenPlaning2.Data.DataModels
{
    public class EventModel
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string MainTheme { get; set; }
        [Column("Creator")]
        public ApplicationUser applicationUser { get; set; }

        public List<SubThem> SubThems { get; set; }

        public EventInfo EventInfo { get; set; }
    }
}
