using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using BusinessObject;

namespace MSMQ_Sender
{   
    
    public partial class F_MessageSender : Form
    {
        MessageQueue queue = null;
        public F_MessageSender()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            String path = @".\private$\phongkehoach";

            if (MessageQueue.Exists(path))
            {
                queue = new MessageQueue(path, QueueAccessMode.Send);
            }
            else
                queue = MessageQueue.Create(path, true);
            queue.Label = "queue cho phong ke hoach";
        }

        private void F_MessageSender_Load(object sender, EventArgs e)
        {

        }

        private void buttonSendText_Click(object sender, EventArgs e)
        {
            String message = richTextBoxSend.Text;
            MessageQueueTransaction transaction = new MessageQueueTransaction();
            transaction.Begin();
            queue.Send(message, transaction);
            transaction.Commit();
        }

        private void buttonSendObject_Click(object sender, EventArgs e)
        {
            Student st = new Student(1001L,"Nguyen Van Teo",new DateTime(1999,10,15));
            MessageQueueTransaction transaction = new MessageQueueTransaction();
            transaction.Begin();
            queue.Send(st, transaction);
            transaction.Commit();
        }
    }
}
