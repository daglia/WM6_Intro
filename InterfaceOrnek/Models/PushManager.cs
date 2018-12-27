using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    class PushManager : INotificator
    {
        public MessageStates MessageState { get; set; }

        public void Send(MessageBase message)
        {
            //Push notify ayarları yapılır.
            MessageState = MessageStates.Pending;
            try
            {
                PushMessage push = message as PushMessage;

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
