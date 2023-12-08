using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra.KiemTraComponents
{
    partial class ButtonCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonCauHoi));
            this.btnXoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCauHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkXoaCauHoi = new System.Windows.Forms.CheckBox();
            this.btnChon = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.lblNoiDungCauHoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(289, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnXoa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXoa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXoa.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(40, 40);
            this.btnXoa.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.StateCommon.Back.Image")));
            this.btnXoa.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnXoa.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnXoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnXoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnXoa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateCommon.Border.Rounding = 5;
            this.btnXoa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnXoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXoa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnXoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnXoa.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnXoa.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnXoa.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoa.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXoa.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXoa.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXoa.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnXoa.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnXoa.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXoa.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXoa.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXoa.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Values.Text = "";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(243, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnSua.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSua.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSua.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(40, 40);
            this.btnSua.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.StateCommon.Back.Image")));
            this.btnSua.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnSua.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSua.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnSua.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnSua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateCommon.Border.Rounding = 5;
            this.btnSua.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnSua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSua.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnSua.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnSua.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnSua.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSua.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSua.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSua.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSua.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSua.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnSua.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnSua.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnSua.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSua.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSua.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSua.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSua.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSua.TabIndex = 19;
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.AllowDrop = true;
            this.btnCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCauHoi.Location = new System.Drawing.Point(3, 3);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnCauHoi.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnCauHoi.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnCauHoi.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnCauHoi.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCauHoi.Size = new System.Drawing.Size(384, 94);
            this.btnCauHoi.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCauHoi.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCauHoi.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnCauHoi.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnCauHoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCauHoi.StateCommon.Border.Rounding = 5;
            this.btnCauHoi.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCauHoi.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCauHoi.TabIndex = 15;
            this.btnCauHoi.Values.Text = "";
            this.btnCauHoi.Click += new System.EventHandler(this.btnCauHoi_Click);
            // 
            // chkXoaCauHoi
            // 
            this.chkXoaCauHoi.AutoSize = true;
            this.chkXoaCauHoi.Location = new System.Drawing.Point(18, 40);
            this.chkXoaCauHoi.Name = "chkXoaCauHoi";
            this.chkXoaCauHoi.Size = new System.Drawing.Size(18, 17);
            this.chkXoaCauHoi.TabIndex = 21;
            this.chkXoaCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.Location = new System.Drawing.Point(335, 26);
            this.btnChon.Name = "btnChon";
            this.btnChon.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnChon.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnChon.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnChon.Size = new System.Drawing.Size(40, 40);
            this.btnChon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateCheckedNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.btnChon.StateCheckedNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.StateCheckedNormal.Back.Image")));
            this.btnChon.StateCheckedNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnChon.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateCheckedNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateCheckedNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateCheckedTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.StateCheckedTracking.Back.Image")));
            this.btnChon.StateCheckedTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnChon.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateCheckedTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateCheckedTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnChon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnChon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateCommon.Border.Rounding = 5;
            this.btnChon.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateDisabled.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.StateDisabled.Back.Image")));
            this.btnChon.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnChon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnChon.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnChon.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateNormal.Border.Rounding = 5;
            this.btnChon.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnChon.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChon.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.TabIndex = 22;
            this.btnChon.Values.Text = "";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lblNoiDungCauHoi
            // 
            this.lblNoiDungCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNoiDungCauHoi.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNoiDungCauHoi.Location = new System.Drawing.Point(98, 24);
            this.lblNoiDungCauHoi.MaximumSize = new System.Drawing.Size(130, 100);
            this.lblNoiDungCauHoi.Name = "lblNoiDungCauHoi";
            this.lblNoiDungCauHoi.Size = new System.Drawing.Size(130, 50);
            this.lblNoiDungCauHoi.TabIndex = 23;
            this.lblNoiDungCauHoi.Text = "label1";
            this.lblNoiDungCauHoi.Click += new System.EventHandler(this.lblNoiDungCauHoi_Click);
            // 
            // ButtonCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoiDungCauHoi);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.chkXoaCauHoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCauHoi);
            this.Name = "ButtonCauHoi";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(390, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCauHoi;
        private System.Windows.Forms.CheckBox chkXoaCauHoi;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnChon;
        private Label lblNoiDungCauHoi;

        public KryptonButton BtnXoa { get => btnXoa; set => btnXoa = value; }
        public KryptonButton BtnSua { get => btnSua; set => btnSua = value; }
        //public KryptonLabel LblChiTietCauHoi { get => lblChiTietCauHoi; set => lblChiTietCauHoi = value; }
        public Label LblNoiDungCauHoi { get => lblNoiDungCauHoi; set => lblNoiDungCauHoi = value; }
        public KryptonButton BtnCauHoi { get => btnCauHoi; set => btnCauHoi = value; }
        public CheckBox ChkXoaCauHoi { get => chkXoaCauHoi; set => chkXoaCauHoi = value; }
        public KryptonCheckButton BtnChon { get => btnChon; set => btnChon = value; }
    }
}
