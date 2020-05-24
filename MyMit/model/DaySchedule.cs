using MyMit.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.model
{
    class DaySchedule
    {
        public DateTime day { get; set; }
        public List<Meeting> meetings { get; set; }

        public DaySchedule(DateTime day, List<Meeting> meetings)
        {
            this.day = day;
            this.meetings = meetings;
        }

    }
}
