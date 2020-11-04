using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailService
{
    class SystemSuportMail : MasterMailServer
    {
        public SystemSuportMail()
        {
            senderMail = "soportesistematbc@gmail.com";
            password = "Admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            initializeSMTP();
        }
    }
}
