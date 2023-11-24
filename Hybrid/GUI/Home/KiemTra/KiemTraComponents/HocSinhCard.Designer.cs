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
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Name = new System.Windows.Forms.Label();
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
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(56, 4);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(60, 60);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.Image = global::Hybrid.Properties.Resources.trend_avatar_12;
            this.kryptonButton2.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // Name
            // 
            this.Name.AutoEllipsis = true;
            this.Name.BackColor = System.Drawing.Color.White;
            this.Name.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(134, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(330, 33);
            this.Name.TabIndex = 0;
            this.Name.Text = "HocSinhKiemTraPanel";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // HocSinhKiemTraPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Name);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.btnShow);
            this.Name.Text = "HocSinhKiemTraPanel";
            this.Size = new System.Drawing.Size(860, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnShow;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.Label Name;
    }
}
