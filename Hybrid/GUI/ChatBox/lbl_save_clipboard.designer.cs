namespace Hybrid.GUI.ChatBox
{
    partial class lbl_save_clipboard
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
            this.lbl_notify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_notify
            // 
            this.lbl_notify.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_notify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_notify.Location = new System.Drawing.Point(5, 0);
            this.lbl_notify.Name = "lbl_notify";
            this.lbl_notify.Size = new System.Drawing.Size(175, 40);
            this.lbl_notify.TabIndex = 0;
            this.lbl_notify.Text = "Copied to clipboard";
            this.lbl_notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_notify.Click += new System.EventHandler(this.lbl_notify_Click);
            // 
            // lbl_save_clipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.lbl_notify);
            this.Name = "lbl_save_clipboard";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Size = new System.Drawing.Size(180, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_notify;
    }
}
