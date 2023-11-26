using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.HomeComponents
{
    partial class ButtonHocLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonHocLieu));
            this.lblChiTietHocLieu = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHocLieu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTieuDeHocLieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiTietHocLieu
            // 
            this.lblChiTietHocLieu.BackColor = System.Drawing.Color.White;
            this.lblChiTietHocLieu.Location = new System.Drawing.Point(112, 56);
            this.lblChiTietHocLieu.Name = "lblChiTietHocLieu";
            this.lblChiTietHocLieu.Size = new System.Drawing.Size(122, 25);
            this.lblChiTietHocLieu.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblChiTietHocLieu.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChiTietHocLieu.TabIndex = 18;
            this.lblChiTietHocLieu.Values.Text = "Chi tiết tài liệu";
            this.lblChiTietHocLieu.Click += new System.EventHandler(this.btnHocLieu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnHocLieu_Click);
            // 
            // btnHocLieu
            // 
            this.btnHocLieu.AllowDrop = true;
            this.btnHocLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHocLieu.Location = new System.Drawing.Point(5, 5);
            this.btnHocLieu.Name = "btnHocLieu";
            this.btnHocLieu.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnHocLieu.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnHocLieu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnHocLieu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnHocLieu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHocLieu.Size = new System.Drawing.Size(860, 90);
            this.btnHocLieu.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnHocLieu.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnHocLieu.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnHocLieu.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnHocLieu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHocLieu.StateCommon.Border.Rounding = 5;
            this.btnHocLieu.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnHocLieu.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnHocLieu.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHocLieu.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnHocLieu.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnHocLieu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHocLieu.TabIndex = 15;
            this.btnHocLieu.Values.Text = "";
            this.btnHocLieu.Click += new System.EventHandler(this.btnHocLieu_Click);
            // 
            // lblTieuDeHocLieu
            // 
            this.lblTieuDeHocLieu.AutoEllipsis = true;
            this.lblTieuDeHocLieu.BackColor = System.Drawing.Color.White;
            this.lblTieuDeHocLieu.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeHocLieu.Location = new System.Drawing.Point(107, 25);
            this.lblTieuDeHocLieu.Name = "lblTieuDeHocLieu";
            this.lblTieuDeHocLieu.Size = new System.Drawing.Size(742, 28);
            this.lblTieuDeHocLieu.TabIndex = 22;
            this.lblTieuDeHocLieu.Text = "Lập trình C#";
            this.lblTieuDeHocLieu.Click += new System.EventHandler(this.btnHocLieu_Click);
            // 
            // ButtonHocLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTieuDeHocLieu);
            this.Controls.Add(this.lblChiTietHocLieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHocLieu);
            this.Name = "ButtonHocLieu";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(870, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblChiTietHocLieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHocLieu;
        private System.Windows.Forms.Label lblTieuDeHocLieu;

        public Label LblTieuDeHocLieu { get => lblTieuDeHocLieu; set => lblTieuDeHocLieu = value; }
    }
}
