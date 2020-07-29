using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.model
{
    public class Meeting
    {
        public int id { get; set ; }
        public int idType { get; set; }
        public int idOwner { get; set; }
        public DateTime startTime { get; set; }
        public int durationMinutes { get; set; }
        public String subject { get; set; }
        public String agendaDescription { get; set; }
        public String meetingMinutes { get; set; }
        public String audioFile { get; set; }
        public String signatureFile { get; set; }
        public string audioTranscription { get; set; }

        public int Closed { get; set; }

        public Meeting() { }

        public Meeting(int id, int idTType, int ownerId, DateTime startTime, int durationMinutes, string subject, string agendaDescription, string meetingMinutes, string audioFile, string signatureFile, string audioTranscription, int Closed)
        {
            this.id = id;
            this.idType = idType;
            this.idOwner = ownerId;
            this.startTime = startTime;
            this.durationMinutes = durationMinutes;
            this.subject = subject;
            this.agendaDescription = agendaDescription;
            this.meetingMinutes = meetingMinutes;
            this.audioFile = audioFile;
            this.signatureFile = signatureFile;
            this.audioTranscription = audioTranscription;
            this.Closed = Closed;
        }

    }
}
