namespace Hybrid.GUI.Home
{
    partial class ChatFrm
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
            this.pnlKhungChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlKhungChat
            // 
            this.pnlKhungChat.AutoScroll = true;
            this.pnlKhungChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlKhungChat.Location = new System.Drawing.Point(0, 0);
            this.pnlKhungChat.Name = "pnlKhungChat";
            this.pnlKhungChat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlKhungChat.Size = new System.Drawing.Size(935, 600);
            this.pnlKhungChat.TabIndex = 0;
            this.pnlKhungChat.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 100);
            this.panel1.TabIndex = 1;
            // 
            // ChatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlKhungChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatFrm";
            this.Text = "ChatFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlKhungChat;
        private System.Windows.Forms.Panel panel1;
    }
}