
namespace _22_8_5_BTNHom_Mail
{
    partial class Inbox
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
            this.components = new System.ComponentModel.Container();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.txb_PassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Inbox = new System.Windows.Forms.Button();
            this.txb_ToatalMessage = new System.Windows.Forms.TextBox();
            this.txb_RecentMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(714, 666);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(169, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(29, 472);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 212);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(160, 248);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(278, 22);
            this.txb_UserName.TabIndex = 4;
            // 
            // txb_PassWord
            // 
            this.txb_PassWord.Location = new System.Drawing.Point(160, 293);
            this.txb_PassWord.Name = "txb_PassWord";
            this.txb_PassWord.Size = new System.Drawing.Size(278, 22);
            this.txb_PassWord.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "passWord";
            // 
            // btn_Inbox
            // 
            this.btn_Inbox.Location = new System.Drawing.Point(160, 412);
            this.btn_Inbox.Name = "btn_Inbox";
            this.btn_Inbox.Size = new System.Drawing.Size(155, 40);
            this.btn_Inbox.TabIndex = 7;
            this.btn_Inbox.Text = "ReadInbox";
            this.btn_Inbox.UseVisualStyleBackColor = true;
            this.btn_Inbox.Click += new System.EventHandler(this.btn_Inbox_Click);
            // 
            // txb_ToatalMessage
            // 
            this.txb_ToatalMessage.Location = new System.Drawing.Point(160, 335);
            this.txb_ToatalMessage.Name = "txb_ToatalMessage";
            this.txb_ToatalMessage.ReadOnly = true;
            this.txb_ToatalMessage.Size = new System.Drawing.Size(100, 22);
            this.txb_ToatalMessage.TabIndex = 8;
            // 
            // txb_RecentMessage
            // 
            this.txb_RecentMessage.Location = new System.Drawing.Point(160, 381);
            this.txb_RecentMessage.Name = "txb_RecentMessage";
            this.txb_RecentMessage.ReadOnly = true;
            this.txb_RecentMessage.Size = new System.Drawing.Size(100, 22);
            this.txb_RecentMessage.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Recent Message";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(530, 251);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(552, 404);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_22_8_5_BTNHom_Mail.Properties.Resources.Inbox;
            this.pictureBox1.Location = new System.Drawing.Point(466, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_RecentMessage);
            this.Controls.Add(this.txb_ToatalMessage);
            this.Controls.Add(this.btn_Inbox);
            this.Controls.Add(this.txb_PassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Exit);
            this.Name = "Inbox";
            this.Text = "Inbox";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.TextBox txb_PassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Inbox;
        private System.Windows.Forms.TextBox txb_ToatalMessage;
        private System.Windows.Forms.TextBox txb_RecentMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}