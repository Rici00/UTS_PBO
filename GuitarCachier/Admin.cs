using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarCachier
{
    class Admin
    {
        private string usernamee;
        private string passwordd;

        //property
        public string LGNUsername
        {
            get { return usernamee; }
            set { usernamee = value; }
        }
        public string LGNPassword
        {
            get { return passwordd; }
            set { passwordd = value; }
        }
        public Boolean Verif(string usern, string passw)
        {
            if (usern == "RiciXYZ" & passw == "123456789")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
