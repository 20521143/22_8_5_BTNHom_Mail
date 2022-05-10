
namespace _22_8_5_BTNHom_Mail
{
    partial class SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_Sender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_PassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Receiver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Subject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Body = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_AttachFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Inbox = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Sender
            // 
            this.txb_Sender.BackColor = System.Drawing.SystemColors.Control;
            this.txb_Sender.Location = new System.Drawing.Point(133, 222);
            this.txb_Sender.Name = "txb_Sender";
            this.txb_Sender.Size = new System.Drawing.Size(456, 22);
            this.txb_Sender.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sender : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // txb_PassWord
            // 
            this.txb_PassWord.BackColor = System.Drawing.SystemColors.Control;
            this.txb_PassWord.Location = new System.Drawing.Point(133, 269);
            this.txb_PassWord.Name = "txb_PassWord";
            this.txb_PassWord.Size = new System.Drawing.Size(456, 22);
            this.txb_PassWord.TabIndex = 2;
            this.txb_PassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "To :";
            // 
            // txb_Receiver
            // 
            this.txb_Receiver.BackColor = System.Drawing.SystemColors.Control;
            this.txb_Receiver.Location = new System.Drawing.Point(133, 324);
            this.txb_Receiver.Name = "txb_Receiver";
            this.txb_Receiver.Size = new System.Drawing.Size(456, 22);
            this.txb_Receiver.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject :";
            // 
            // txb_Subject
            // 
            this.txb_Subject.BackColor = System.Drawing.SystemColors.Control;
            this.txb_Subject.Location = new System.Drawing.Point(133, 373);
            this.txb_Subject.Name = "txb_Subject";
            this.txb_Subject.Size = new System.Drawing.Size(456, 22);
            this.txb_Subject.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Body :";
            // 
            // txb_Body
            // 
            this.txb_Body.BackColor = System.Drawing.SystemColors.Control;
            this.txb_Body.Location = new System.Drawing.Point(133, 423);
            this.txb_Body.Multiline = true;
            this.txb_Body.Name = "txb_Body";
            this.txb_Body.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Body.Size = new System.Drawing.Size(456, 200);
            this.txb_Body.TabIndex = 8;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(242, 649);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(233, 35);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_AttachFile
            // 
            this.btn_AttachFile.Location = new System.Drawing.Point(865, 222);
            this.btn_AttachFile.Name = "btn_AttachFile";
            this.btn_AttachFile.Size = new System.Drawing.Size(198, 47);
            this.btn_AttachFile.TabIndex = 11;
            this.btn_AttachFile.Text = "Attach File";
            this.btn_AttachFile.UseVisualStyleBackColor = true;
            this.btn_AttachFile.Click += new System.EventHandler(this.btn_AttachFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(649, 283);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(600, 340);
            this.listBox1.TabIndex = 12;
            // 
            // btn_Inbox
            // 
            this.btn_Inbox.Location = new System.Drawing.Point(895, 645);
            this.btn_Inbox.Name = "btn_Inbox";
            this.btn_Inbox.Size = new System.Drawing.Size(121, 43);
            this.btn_Inbox.TabIndex = 13;
            this.btn_Inbox.Text = "Inbox";
            this.btn_Inbox.UseVisualStyleBackColor = true;
            this.btn_Inbox.Click += new System.EventHandler(this.btn_Inbox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(280, 297);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Show password!";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_22_8_5_BTNHom_Mail.Properties.Resources.Gmail_200;
            this.pictureBox1.Location = new System.Drawing.Point(522, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1261, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Inbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_AttachFile);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Body);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Receiver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_PassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Sender);
            this.Name = "SendMail";
            this.Text = "Send Mail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Sender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Receiver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Body;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_AttachFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Inbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

