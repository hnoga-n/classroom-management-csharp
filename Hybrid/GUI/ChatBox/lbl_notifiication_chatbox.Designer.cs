namespace Hybrid.GUI.ChatBox
{
    partial class lbl_notifiication_chatbox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.notice_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.notice_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 40);
            this.panel1.TabIndex = 0;
            // 
            // notice_lbl
            // 
            this.notice_lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.notice_lbl.AutoSize = true;
            this.notice_lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.notice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.notice_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notice_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notice_lbl.Location = new System.Drawing.Point(351, 7);
            this.notice_lbl.Name = "notice_lbl";
            this.notice_lbl.Padding = new System.Windows.Forms.Padding(4);
            this.notice_lbl.Size = new System.Drawing.Size(172, 26);
            this.notice_lbl.TabIndex = 8;
            this.notice_lbl.Text = "Tạo lớp học thành công";
            this.notice_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_notifiication_chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "lbl_notifiication_chatbox";
            this.Size = new System.Drawing.Size(875, 40);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label notice_lbl;
    }
}
