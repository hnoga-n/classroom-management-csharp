namespace Hybrid.GUI.Todo
{
    partial class TaskNotDoneButton
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
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.sangclockPic = new System.Windows.Forms.PictureBox();
            this.lblNotDone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton2.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(284, 74);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonButton2.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryptonButton2.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateCommon.Content.ShortText.Image = global::Hybrid.Properties.Resources.icons8_done_30;
            this.kryptonButton2.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.kryptonButton2.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.TabIndex = 6;
            this.kryptonButton2.Values.Text = "";
            // 
            // sangclockPic
            // 
            this.sangclockPic.BackgroundImage = global::Hybrid.Properties.Resources.icons8_sandclock_50;
            this.sangclockPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sangclockPic.Location = new System.Drawing.Point(45, 12);
            this.sangclockPic.Name = "sangclockPic";
            this.sangclockPic.Size = new System.Drawing.Size(43, 46);
            this.sangclockPic.TabIndex = 9;
            this.sangclockPic.TabStop = false;
            // 
            // lblNotDone
            // 
            this.lblNotDone.AutoSize = true;
            this.lblNotDone.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.lblNotDone.Location = new System.Drawing.Point(118, 24);
            this.lblNotDone.Name = "lblNotDone";
            this.lblNotDone.Size = new System.Drawing.Size(114, 24);
            this.lblNotDone.TabIndex = 10;
            this.lblNotDone.Text = "Chưa xử lý";
            this.lblNotDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskNotDoneButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNotDone);
            this.Controls.Add(this.sangclockPic);
            this.Controls.Add(this.kryptonButton2);
            this.Name = "TaskNotDoneButton";
            this.Size = new System.Drawing.Size(284, 74);
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.PictureBox sangclockPic;
        private System.Windows.Forms.Label lblNotDone;
    }
}
