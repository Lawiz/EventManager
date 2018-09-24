using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvenPlaning2.Models.EventViewModels
{
    public class IndexEventViewModel
    {
        [Display(Name="Event Name")]
        public string Name { get; set; }
        public string Id { get; set; }
        [Display(Name="Event main Them")]
        public string MainThem { get; set; }
        [Display(Name="Event Date")]
        public DateTime EvenDate { get; set; }
        [Display(Name ="Signed Up")]
        public int SignedUp { get; set; }
        [Display(Name="Max Partecipantes")]
        public int MaxPartesipantes { get; set; }

    }
}
