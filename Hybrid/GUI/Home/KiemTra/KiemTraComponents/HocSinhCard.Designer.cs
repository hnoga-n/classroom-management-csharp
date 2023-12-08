namespace Hybrid.GUI.Home.HomeComponents
{
    partial class HocSinhCard
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
            this.btnShow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Name = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.lblSubmitAt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.Location = new System.Drawing.Point(0, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnShow.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnShow.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnShow.Size = new System.Drawing.Size(860, 70);
            this.btnShow.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnShow.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnShow.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnShow.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnShow.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnShow.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnShow.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnShow.TabIndex = 0;
            this.btnShow.Values.Text = "";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Name
            // 
            this.Name.AutoEllipsis = true;
            this.Name.BackColor = System.Drawing.Color.White;
            this.Name.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(158, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(330, 33);
            this.Name.TabIndex = 0;
            this.Name.Text = "HocSinhKiemTraPanel";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // avatar
            // 
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Location = new System.Drawing.Point(46, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(73, 67);
            this.avatar.TabIndex = 1;
            this.avatar.TabStop = false;
            // 
            // lblSubmitAt
            // 
            this.lblSubmitAt.BackColor = System.Drawing.Color.White;
            this.lblSubmitAt.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitAt.Location = new System.Drawing.Point(159, 36);
            this.lblSubmitAt.Name = "lblSubmitAt";
            this.lblSubmitAt.Size = new System.Drawing.Size(430, 20);
            this.lblSubmitAt.TabIndex = 10;
            // 
            // HocSinhCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSubmitAt);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.btnShow);
            this.Size = new System.Drawing.Size(860, 70);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnShow;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label lblSubmitAt;
    }
}
