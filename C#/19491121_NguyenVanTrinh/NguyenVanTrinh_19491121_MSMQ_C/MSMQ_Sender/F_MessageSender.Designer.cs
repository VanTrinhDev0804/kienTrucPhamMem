namespace MSMQ_Sender
{
    partial class F_MessageSender
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
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.buttonSendObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(260, 184);
            this.richTextBoxSend.TabIndex = 0;
            this.richTextBoxSend.Text = "";
            // 
            // buttonSendText
            // 
            this.buttonSendText.Location = new System.Drawing.Point(116, 215);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(75, 23);
            this.buttonSendText.TabIndex = 1;
            this.buttonSendText.Text = "Send Text";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // buttonSendObject
            // 
            this.buttonSendObject.Location = new System.Drawing.Point(197, 215);
            this.buttonSendObject.Name = "buttonSendObject";
            this.buttonSendObject.Size = new System.Drawing.Size(75, 23);
            this.buttonSendObject.TabIndex = 2;
            this.buttonSendObject.Text = "Send Object";
            this.buttonSendObject.UseVisualStyleBackColor = true;
            this.buttonSendObject.Click += new System.EventHandler(this.buttonSendObject_Click);
            // 
            // F_MessageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSendObject);
            this.Controls.Add(this.buttonSendText);
            this.Controls.Add(this.richTextBoxSend);
            this.Name = "F_MessageSender";
            this.Text = "F_MessageSender";
            this.Load += new System.EventHandler(this.F_MessageSender_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.Button buttonSendText;
        private System.Windows.Forms.Button buttonSendObject;
    }
}