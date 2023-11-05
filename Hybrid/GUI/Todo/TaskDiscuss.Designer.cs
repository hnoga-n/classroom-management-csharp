namespace Hybrid.GUI.Todo
{
    partial class TaskDiscuss
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
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDiscuss = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblDiscussTitle = new System.Windows.Forms.Label();
            this.pictureBoxDiscuss = new System.Windows.Forms.PictureBox();
            this.btnDoDicuss = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscuss)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(312, 42);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton2.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(923, 80);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 10;
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDiscuss);
            this.panel1.Controls.Add(this.lblDeadline);
            this.panel1.Location = new System.Drawing.Point(214, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 31);
            this.panel1.TabIndex = 13;
            // 
            // lblDiscuss
            // 
            this.lblDiscuss.AutoSize = true;
            this.lblDiscuss.Font = new System.Drawing.Font("Roboto Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscuss.Location = new System.Drawing.Point(3, 7);
            this.lblDiscuss.Name = "lblDiscuss";
            this.lblDiscuss.Size = new System.Drawing.Size(72, 15);
            this.lblDiscuss.TabIndex = 3;
            this.lblDiscuss.Text = "Thảo luận";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(92, 6);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(301, 16);
            this.lblDeadline.TabIndex = 4;
            this.lblDeadline.Text = "23:23 03/03/2024 Hạn chót | Công nghệ phần mềm";
            // 
            // lblDiscussTitle
            // 
            this.lblDiscussTitle.AutoSize = true;
            this.lblDiscussTitle.BackColor = System.Drawing.Color.White;
            this.lblDiscussTitle.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscussTitle.Location = new System.Drawing.Point(210, 14);
            this.lblDiscussTitle.Name = "lblDiscussTitle";
            this.lblDiscussTitle.Size = new System.Drawing.Size(91, 20);
            this.lblDiscussTitle.TabIndex = 12;
            this.lblDiscussTitle.Text = "Thảo luận";
            this.lblDiscussTitle.Click += new System.EventHandler(this.lblTtitle_Click);
            // 
            // pictureBoxDiscuss
            // 
            this.pictureBoxDiscuss.BackColor = System.Drawing.Color.White;
            this.pictureBoxDiscuss.BackgroundImage = global::Hybrid.Properties.Resources.icons8_discuss_91;
            this.pictureBoxDiscuss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDiscuss.InitialImage = null;
            this.pictureBoxDiscuss.Location = new System.Drawing.Point(86, 12);
            this.pictureBoxDiscuss.Name = "pictureBoxDiscuss";
            this.pictureBoxDiscuss.Size = new System.Drawing.Size(63, 56);
            this.pictureBoxDiscuss.TabIndex = 11;
            this.pictureBoxDiscuss.TabStop = false;
            // 
            // btnDoDicuss
            // 
            this.btnDoDicuss.Location = new System.Drawing.Point(778, 24);
            this.btnDoDicuss.Name = "btnDoDicuss";
            this.btnDoDicuss.Size = new System.Drawing.Size(113, 35);
            this.btnDoDicuss.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoDicuss.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDoDicuss.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDoDicuss.StateCommon.Border.Rounding = 5;
            this.btnDoDicuss.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDoDicuss.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoDicuss.TabIndex = 12;
            this.btnDoDicuss.Values.Text = "Thảo luận";
            // 
            // TaskDiscuss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDoDicuss);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDiscussTitle);
            this.Controls.Add(this.pictureBoxDiscuss);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Name = "TaskDiscuss";
            this.Size = new System.Drawing.Size(923, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscuss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDiscuss;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblDiscussTitle;
        private System.Windows.Forms.PictureBox pictureBoxDiscuss;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDoDicuss;
    }
}
