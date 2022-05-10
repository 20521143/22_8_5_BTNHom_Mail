using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.Net;
using System.IO;



namespace _22_8_5_BTNHom_Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txb_Sender_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            
                try
                {
                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential(txb_Sender.Text, txb_PassWord.Text);

                    MailMessage message = new MailMessage(txb_Sender.Text, txb_Receiver.Text);
                    message.Subject = txb_Subject.Text;
                    message.Body = txb_Receiver.Text;

                    

                    if (listBox1.Items.Count > 0)
                    {
                        foreach (var filename in listBox1.Items)
                        {
                            //Kiểm tra file có tồn tại trong ổ đĩa không
                            if (File.Exists(filename.ToString()))
                            {
                                //Thêm file đính kèm vào tin nhắn
                                message.Attachments.Add(new Attachment(filename.ToString()));
                            }
                        }
                    }

                    mailclient.Send(message);
                    MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                catch (Exception ex)
                {
                    MessageBox.Show( "Error","Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
        {
            //Cho phép chọn nhiều dòng trong OpenFileDialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.ShowDialog();
                foreach (var filename in ofd.FileNames)
                {
                    //Thêm các file đã chọn vào listBox1
                    listBox1.Items.Add(filename.ToString());
                }
            }

        }

        private void btn_Inbox_Click(object sender, EventArgs e)
        {
            Inbox ib = new Inbox();
            ib.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txb_PassWord.UseSystemPasswordChar = false;
            }    
            else
            {
                txb_PassWord.UseSystemPasswordChar = true;
            }    
        }
    }
}
