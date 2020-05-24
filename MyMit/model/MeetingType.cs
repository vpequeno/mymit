using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.model
{
    [Serializable]
    public class MeetingType
    {
        public int id { get; set; }
        public String name { get; set; }

        public MeetingType(int id, String typeName)
        {
            this.id = id;
            this.name = typeName;
        }

        public MeetingType()
        {
            this.id = 0;
            this.name = "";
        }

        public override String ToString() 
        {
            return this.name;
        }
    }
}
