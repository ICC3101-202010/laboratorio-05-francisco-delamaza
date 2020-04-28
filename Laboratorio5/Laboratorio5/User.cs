using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Laboratorio5
{
    class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EmailVerifiedEventArgs args);

        public event EmailVerifiedEventHandler EmailVerified;

        protected virtual void OnEmailSend(object source, EmailSentEventArgs l)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Verificar Usuario? ('Y'/'N')");
            string v = Console.ReadLine();
            if (v == "Y")
            {
                EmailVerified(this, new EmailVerifiedEventArgs());

            }
            else
            {

            }

        }
    }
}
