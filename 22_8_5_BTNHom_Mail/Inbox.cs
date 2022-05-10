using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using MimeKit;
using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;
using MailKit.Security;

namespace _22_8_5_BTNHom_Mail
{
    public partial class Inbox : Form
    {
        public Inbox()
        {
            InitializeComponent();
        }

        private void Inbox_Load(object sender, EventArgs e)
        {

        }

        






        private void btn_Inbox_Click(object sender, EventArgs e)
        {
            
                using (var client = new ImapClient())
                {
                   
                        client.Connect("imap.gmail.com", 993, true);

                        


                    //client.Authenticate(txb_UserName.Text, txb_PassWord.Text);
                    client.Authenticate("nguyenthanhlong012002@gmail.com", "Cong@$1412");
                    var folder = client.GetFolder(new FolderNamespace('.', ""));


                    // The Inbox folder is always available on all IMAP servers...
                    var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);

                        txb_ToatalMessage.Text = inbox.Count.ToString();
                        txb_RecentMessage.Text = inbox.Recent.ToString();
                        //Console.WriteLine("Total messages: {0}", inbox.Count);
                        //Console.WriteLine("Recent messages: {0}", inbox.Recent);

                        for (int i = 0; i < inbox.Count; i++)
                        {
                            var message = inbox.GetMessage(i);
                            
                            listBox1.Items.Add(message.Subject);
                            DownloadMessages();
                            //Console.WriteLine("Subject: {0}", message.Subject);
                        }
                   
                         client.Disconnect(true);

                }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void DownloadMessages()
        {
            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

                client.Authenticate("nguyenthanhlong012002@gmail.com", "Cong@$1412");

                client.Inbox.Open(FolderAccess.ReadOnly);

                var uids = client.Inbox.Search(SearchQuery.All);

                foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);

                    // write the message to a file
                    message.WriteTo(string.Format("{0}.eml", uid));
                    
                }

                client.Disconnect(true);
            }
        }
    }
}
