using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvenPlaning2.Data.DataModels;
	
namespace EvenPlaning2.Models.EventViewModels
{
    public class EventDetailsForMore
    {
        public string Name { get; set; }

        public string MainThem { get; set; }

        public int MaxCountPartecipantes { get; set; }

        public int EventCountPartecipantes { get; set; }

        public List<string> SubThems { get; set; }

    }
}
