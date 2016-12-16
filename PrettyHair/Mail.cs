using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    //public delegate void MailHandler();

    public class Mail
    {
        private bool sentMail = true;

        public void sendMail()
        {
            sentMail = true;
        }

        public void mailSent()
        {
            sentMail = true;
        }

        public void dontSend()
        {
            sentMail = false;
        }
    }
}
