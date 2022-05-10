
namespace _22_8_5_BTNHom_Mail
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // txb_Sender
            // 
            this.txb_Sender.Location = new System.Drawing.Point(133, 42);
            this.txb_Sender.Name = "txb_Sender";
            this.txb_Sender.Size = new System.Drawing.Size(456, 22);
            this.txb_Sender.TabIndex = 0;
            this.txb_Sender.TextChanged += new System.EventHandler(this.txb_Sender_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "PassWord";
            // 
            // txb_PassWord
            // 
            this.txb_PassWord.Location = new System.Drawing.Point(133, 89);
            this.txb_PassWord.Name = "txb_PassWord";
            this.txb_PassWord.Size = new System.Drawing.Size(456, 22);
            this.txb_PassWord.TabIndex = 2;
            this.txb_PassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // txb_Receiver
            // 
            this.txb_Receiver.Location = new System.Drawing.Point(133, 144);
            this.txb_Receiver.Name = "txb_Receiver";
            this.txb_Receiver.Size = new System.Drawing.Size(456, 22);
            this.txb_Receiver.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject";
            // 
            // txb_Subject
            // 
            this.txb_Subject.Location = new System.Drawing.Point(133, 193);
            this.txb_Subject.Name = "txb_Subject";
            this.txb_Subject.Size = new System.Drawing.Size(456, 22);
            this.txb_Subject.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Body";
            // 
            // txb_Body
            // 
            this.txb_Body.Location = new System.Drawing.Point(133, 243);
            this.txb_Body.Multiline = true;
            this.txb_Body.Name = "txb_Body";
            this.txb_Body.Size = new System.Drawing.Size(456, 200);
            this.txb_Body.TabIndex = 8;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(133, 496);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(526, 35);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_AttachFile
            // 
            this.btn_AttachFile.Location = new System.Drawing.Point(649, 47);
            this.btn_AttachFile.Name = "btn_AttachFile";
            this.btn_AttachFile.Size = new System.Drawing.Size(198, 47);
            this.btn_AttachFile.TabIndex = 11;
            this.btn_AttachFile.Text = "AttachFile";
            this.btn_AttachFile.UseVisualStyleBackColor = true;
            this.btn_AttachFile.Click += new System.EventHandler(this.btn_AttachFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(649, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 196);
            this.listBox1.TabIndex = 12;
            // 
            // btn_Inbox
            // 
            this.btn_Inbox.Location = new System.Drawing.Point(20, 475);
            this.btn_Inbox.Name = "btn_Inbox";
            this.btn_Inbox.Size = new System.Drawing.Size(75, 23);
            this.btn_Inbox.TabIndex = 13;
            this.btn_Inbox.Text = "Inbox";
            this.btn_Inbox.UseVisualStyleBackColor = true;
            this.btn_Inbox.Click += new System.EventHandler(this.btn_Inbox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(280, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Show password!";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 702);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

