using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.model
{
    /*
    Classe representando o objeto User
    */

    [Serializable]
    public class User
    {
        public int id { get; set; }
        public int idProfilePicture { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public bool isAdmin { get; set; }
        public bool active { get; set; }
        public byte[] ProfilePicture { get; set; }

        public User(int id, string name, string email, string password, int idProfilePicture, bool isAdmin, bool active)
        {
            this.id = id;
            this.idProfilePicture = idProfilePicture;
            this.name = name;
            this.email = email;
            this.password = password;
            this.isAdmin = isAdmin;
            this.active = active;
        }

        public User()
        {
            this.id = 0;
            this.idProfilePicture = 0;
            this.name = "";
            this.email = "";
            this.password = "";
            this.isAdmin = false;
            this.active = false;
        }

    }
}
