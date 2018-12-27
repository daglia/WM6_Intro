using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class EmailManager : INotificator
    {
        public MessageStates MessageState { get; set; }

        public void Send(MessageBase message)
        {
            //E-mail ayarları yapılır.
            MessageState = MessageStates.Pending;
            try
            {
                EmailMessage email = message as EmailMessage;

                MessageState = MessageStates.Sent;
            }
            catch (Exception ex)
            {
                MessageState = MessageStates.Failed;
                throw ex;
            }
        }
    }
}
