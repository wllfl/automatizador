using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioMailing.classes
{
    class Mailing
    {
        private string email;
        private bool checkbox;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool Checkbox
        {
            get { return checkbox; }
            set { checkbox = value; }
        }
    }
}
