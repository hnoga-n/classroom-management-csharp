namespace Hybrid.GUI.Todo
{
    partial class TaskHomework
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
            this.btnTask = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHomework = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblTtitle = new System.Windows.Forms.Label();
            this.pictureBoxHomework = new System.Windows.Forms.PictureBox();
            this.btnDoHomework = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomework)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTask
            // 
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTask.Location = new System.Drawing.Point(0, 0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(923, 80);
            this.btnTask.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTask.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTask.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTask.StateCommon.Border.Rounding = 10;
            this.btnTask.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTask.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTask.TabIndex = 0;
            this.btnTask.Values.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHomework);
            this.panel1.Controls.Add(this.lblDeadline);
            this.panel1.Location = new System.Drawing.Point(214, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 31);
            this.panel1.TabIndex = 9;
            // 
            // lblHomework
            // 
            this.lblHomework.AutoSize = true;
            this.lblHomework.Font = new System.Drawing.Font("Roboto Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomework.Location = new System.Drawing.Point(3, 7);
            this.lblHomework.Name = "lblHomework";
            this.lblHomework.Size = new System.Drawing.Size(53, 15);
            this.lblHomework.TabIndex = 3;
            this.lblHomework.Text = "Bài tập";
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
            // lblTtitle
            // 
            this.lblTtitle.AutoSize = true;
            this.lblTtitle.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtitle.Location = new System.Drawing.Point(210, 14);
            this.lblTtitle.Name = "lblTtitle";
            this.lblTtitle.Size = new System.Drawing.Size(126, 20);
            this.lblTtitle.TabIndex = 8;
            this.lblTtitle.Text = "Bài tập 10/20";
            // 
            // pictureBoxHomework
            // 
            this.pictureBoxHomework.BackgroundImage = global::Hybrid.Properties.Resources.icons8_homework_100;
            this.pictureBoxHomework.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHomework.InitialImage = null;
            this.pictureBoxHomework.Location = new System.Drawing.Point(86, 12);
            this.pictureBoxHomework.Name = "pictureBoxHomework";
            this.pictureBoxHomework.Size = new System.Drawing.Size(63, 56);
            this.pictureBoxHomework.TabIndex = 7;
            this.pictureBoxHomework.TabStop = false;
            // 
            // btnDoHomework
            // 
            this.btnDoHomework.Location = new System.Drawing.Point(775, 24);
            this.btnDoHomework.Name = "btnDoHomework";
            this.btnDoHomework.Size = new System.Drawing.Size(113, 35);
            this.btnDoHomework.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoHomework.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDoHomework.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDoHomework.StateCommon.Border.Rounding = 5;
            this.btnDoHomework.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDoHomework.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoHomework.TabIndex = 11;
            this.btnDoHomework.Values.Text = "Làm bài tập";
            // 
            // TaskHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDoHomework);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTtitle);
            this.Controls.Add(this.pictureBoxHomework);
            this.Controls.Add(this.btnTask);
            this.Name = "TaskHomework";
            this.Size = new System.Drawing.Size(923, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomework)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHomework;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblTtitle;
        private System.Windows.Forms.PictureBox pictureBoxHomework;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDoHomework;
    }
}
