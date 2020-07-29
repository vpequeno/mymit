using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.model
{
    public class UserTask
    {
        public int Id { get; set; }
        public int IdMeeting { get; set; }
        public int IdOwner { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public UserTask() { }
    }
}
