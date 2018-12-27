using InterfaceOrnek.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex < 0) return;

            INotificator notify;
            switch (cmbMethod.SelectedIndex)
            {
                case 0: //SMS
                    notify = new SmsManager();
                    MessageBase sms = new SmsMessage()
                    {
                        Body = "sms body",
                        Sender = "sms sender"
                    };
                    notify.Send(sms);
                    if (notify.MessageState == MessageStates.Sent)
                        MessageBox.Show("SMS gönderildi.");
                    break;
                case 1: //E-mail
                    notify = new EmailManager();
                    MessageBase email = new EmailMessage()
                    {
                        Body = "email body",
                        Sender = "email sender",
                        Subject = "email subject"
                    };
                    notify.Send(email);
                    if (notify.MessageState == MessageStates.Sent)
                        MessageBox.Show("E-mail gönderildi.");
                    break;
                default: //Push
                    notify = new PushManager();
                    MessageBase push = new PushMessage()
                    {
                        Body = "push body",
                        Sender = "push sender",
                        Channel = "push channel"
                    };
                    notify.Send(push);
                    if (notify.MessageState == MessageStates.Sent)
                        MessageBox.Show("Push gönderildi.");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
