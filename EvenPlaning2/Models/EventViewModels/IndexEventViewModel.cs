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
        [Display(Name="Event main Them")]
        public string MainThem { get; set; }
        [Display(Name="Event Date")]
        public DateTime EvenDate { get; set; }

    }
}
