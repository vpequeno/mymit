using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.model
{
    public class MeetingInvite
    {
        public int id { get; set; }
        public int idMeeting { get; set; }
        public int idUser { get; set; }
        public bool attended { get; set; }

        public MeetingInvite()
        {
        }

        public MeetingInvite(int id, int idMeeting, int idUser, bool attended)
        {
            this.id = id;
            this.idMeeting = idMeeting;
            this.idUser = idUser;
            this.attended = attended;
        }
    }
}
