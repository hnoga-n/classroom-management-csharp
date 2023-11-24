namespace Hybrid.GUI.ChatBox
{
    partial class OutgoingMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingMessage));
            this.panel_contain_out_mess = new System.Windows.Forms.Panel();
            this.lbl_sent_time = new System.Windows.Forms.Label();
            this.lbl_sent_content = new System.Windows.Forms.Label();
            this.panel_contain_out_mess.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contain_out_mess
            // 
            this.panel_contain_out_mess.AutoSize = true;
            this.panel_contain_out_mess.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_contain_out_mess.Controls.Add(this.lbl_sent_time);
            this.panel_contain_out_mess.Controls.Add(this.lbl_sent_content);
            this.panel_contain_out_mess.Location = new System.Drawing.Point(426, 3);
            this.panel_contain_out_mess.MaximumSize = new System.Drawing.Size(435, 0);
            this.panel_contain_out_mess.Name = "panel_contain_out_mess";
            this.panel_contain_out_mess.Size = new System.Drawing.Size(435, 268);
            this.panel_contain_out_mess.TabIndex = 0;
            // 
            // lbl_sent_time
            // 
            this.lbl_sent_time.AutoSize = true;
            this.lbl_sent_time.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_sent_time.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_sent_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_time.Location = new System.Drawing.Point(375, 0);
            this.lbl_sent_time.Name = "lbl_sent_time";
            this.lbl_sent_time.Padding = new System.Windows.Forms.Padding(0, 4, 10, 0);
            this.lbl_sent_time.Size = new System.Drawing.Size(60, 24);
            this.lbl_sent_time.TabIndex = 5;
            this.lbl_sent_time.Text = "12:40";
            // 
            // lbl_sent_content
            // 
            this.lbl_sent_content.AutoSize = true;
            this.lbl_sent_content.BackColor = System.Drawing.Color.White;
            this.lbl_sent_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_content.Location = new System.Drawing.Point(3, 34);
            this.lbl_sent_content.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_sent_content.MaximumSize = new System.Drawing.Size(430, 0);
            this.lbl_sent_content.Name = "lbl_sent_content";
            this.lbl_sent_content.Padding = new System.Windows.Forms.Padding(7);
            this.lbl_sent_content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sent_content.Size = new System.Drawing.Size(428, 234);
            this.lbl_sent_content.TabIndex = 4;
            this.lbl_sent_content.Text = resources.GetString("lbl_sent_content.Text");
            // 
            // OutgoingMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel_contain_out_mess);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MaximumSize = new System.Drawing.Size(875, 0);
            this.Name = "OutgoingMessage";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(875, 274);
            this.panel_contain_out_mess.ResumeLayout(false);
            this.panel_contain_out_mess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_contain_out_mess;
        private System.Windows.Forms.Label lbl_sent_time;
        private System.Windows.Forms.Label lbl_sent_content;
    }
}
