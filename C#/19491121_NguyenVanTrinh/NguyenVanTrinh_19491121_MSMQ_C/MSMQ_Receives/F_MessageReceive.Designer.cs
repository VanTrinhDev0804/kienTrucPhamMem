namespace MSMQ_Receive
{
    partial class F_MessageReceive
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
            this.txtRichTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtRichTextBoxReceive
            // 
            this.txtRichTextBoxReceive.Location = new System.Drawing.Point(12, 12);
            this.txtRichTextBoxReceive.Name = "txtRichTextBoxReceive";
            this.txtRichTextBoxReceive.Size = new System.Drawing.Size(260, 237);
            this.txtRichTextBoxReceive.TabIndex = 0;
            this.txtRichTextBoxReceive.Text = "";
            // 
            // F_MessageReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtRichTextBoxReceive);
            this.Name = "F_MessageReceive";
            this.Text = "F_MessageReceive";
            this.Load += new System.EventHandler(this.F_MessageReceive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtRichTextBoxReceive;
    }
}