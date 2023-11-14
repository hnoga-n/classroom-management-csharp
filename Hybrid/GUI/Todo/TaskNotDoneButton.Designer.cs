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
            this.btnChuaxuly = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.sangclockPic = new System.Windows.Forms.PictureBox();
            this.lblNotDone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChuaxuly
            // 
            this.btnChuaxuly.Location = new System.Drawing.Point(0, 0);
            this.btnChuaxuly.Name = "btnChuaxuly";
            this.btnChuaxuly.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnChuaxuly.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChuaxuly.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChuaxuly.Size = new System.Drawing.Size(284, 74);
            this.btnChuaxuly.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnChuaxuly.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnChuaxuly.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.btnChuaxuly.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaxuly.StateCommon.Content.ShortText.Image = global::Hybrid.Properties.Resources.icons8_done_30;
            this.btnChuaxuly.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnChuaxuly.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnChuaxuly.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChuaxuly.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChuaxuly.TabIndex = 6;
            this.btnChuaxuly.Values.Text = "";
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
            this.lblNotDone.MouseEnter += new System.EventHandler(this.lblNotDone_MouseEnter);
            this.lblNotDone.MouseLeave += new System.EventHandler(this.lblNotDone_MouseLeave);
            // 
            // TaskNotDoneButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNotDone);
            this.Controls.Add(this.sangclockPic);
            this.Controls.Add(this.btnChuaxuly);
            this.Name = "TaskNotDoneButton";
            this.Size = new System.Drawing.Size(284, 74);
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChuaxuly;
        private System.Windows.Forms.PictureBox sangclockPic;
        private System.Windows.Forms.Label lblNotDone;
    }
}
