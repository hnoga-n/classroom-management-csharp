using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    partial class HomeFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlLopHocContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoLop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnThamGia = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlGiaoDienLopHocContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pnlLopHocContainer);
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(400, 790);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pnlLopHocContainer
            // 
            this.pnlLopHocContainer.AutoScroll = true;
            this.pnlLopHocContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLopHocContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlLopHocContainer.Location = new System.Drawing.Point(0, 155);
            this.pnlLopHocContainer.Name = "pnlLopHocContainer";
            this.pnlLopHocContainer.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.pnlLopHocContainer.Size = new System.Drawing.Size(400, 635);
            this.pnlLopHocContainer.TabIndex = 4;
            this.pnlLopHocContainer.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btnTaoLop);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnThamGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 155);
            this.panel1.TabIndex = 3;
            // 
            // btnTaoLop
            // 
            this.btnTaoLop.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnTaoLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoLop.Location = new System.Drawing.Point(210, 77);
            this.btnTaoLop.Name = "btnTaoLop";
            this.btnTaoLop.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTaoLop.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTaoLop.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnTaoLop.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoLop.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoLop.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnTaoLop.Size = new System.Drawing.Size(180, 60);
            this.btnTaoLop.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTaoLop.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTaoLop.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoLop.StateCommon.Back.Image")));
            this.btnTaoLop.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnTaoLop.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.btnTaoLop.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnTaoLop.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnTaoLop.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.StateCommon.Border.Rounding = 5;
            this.btnTaoLop.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 23, 5, 0);
            this.btnTaoLop.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnTaoLop.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnTaoLop.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoLop.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnTaoLop.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnTaoLop.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnTaoLop.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnTaoLop.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnTaoLop.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnTaoLop.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnTaoLop.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTaoLop.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoLop.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoLop.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnTaoLop.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnTaoLop.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnTaoLop.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnTaoLop.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnTaoLop.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoLop.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoLop.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoLop.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnTaoLop.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnTaoLop.TabIndex = 9;
            this.btnTaoLop.Values.Text = "Tạo lớp học";
            this.btnTaoLop.Click += new System.EventHandler(this.btnTaoLop_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(20, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(359, 36);
            this.txtTimKiem.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.txtTimKiem.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.txtTimKiem.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimKiem.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTimKiem.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtTimKiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTimKiem.StateCommon.Border.Rounding = 5;
            this.txtTimKiem.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnThamGia
            // 
            this.btnThamGia.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThamGia.Location = new System.Drawing.Point(12, 77);
            this.btnThamGia.Name = "btnThamGia";
            this.btnThamGia.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnThamGia.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnThamGia.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnThamGia.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThamGia.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThamGia.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThamGia.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThamGia.Size = new System.Drawing.Size(180, 60);
            this.btnThamGia.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnThamGia.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnThamGia.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnThamGia.StateCommon.Back.Image")));
            this.btnThamGia.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnThamGia.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.btnThamGia.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThamGia.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThamGia.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThamGia.StateCommon.Border.Rounding = 5;
            this.btnThamGia.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 23, 5, 0);
            this.btnThamGia.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThamGia.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnThamGia.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThamGia.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnThamGia.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnThamGia.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThamGia.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThamGia.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThamGia.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnThamGia.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnThamGia.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnThamGia.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThamGia.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThamGia.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThamGia.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThamGia.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThamGia.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnThamGia.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnThamGia.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnThamGia.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnThamGia.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThamGia.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThamGia.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThamGia.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThamGia.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnThamGia.TabIndex = 8;
            this.btnThamGia.Values.Text = "Tham gia lớp học";
            this.btnThamGia.Click += new System.EventHandler(this.btnThamGia_Click);
            // 
            // pnlGiaoDienLopHocContainer
            // 
            this.pnlGiaoDienLopHocContainer.BackColor = System.Drawing.Color.White;
            this.pnlGiaoDienLopHocContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGiaoDienLopHocContainer.Location = new System.Drawing.Point(400, 0);
            this.pnlGiaoDienLopHocContainer.Name = "pnlGiaoDienLopHocContainer";
            this.pnlGiaoDienLopHocContainer.Size = new System.Drawing.Size(935, 790);
            this.pnlGiaoDienLopHocContainer.TabIndex = 1;
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 790);
            this.Controls.Add(this.pnlGiaoDienLopHocContainer);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeFrm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThamGia;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTaoLop;
        private System.Windows.Forms.FlowLayoutPanel pnlLopHocContainer;
        private Panel pnlGiaoDienLopHocContainer;

        public FlowLayoutPanel PnlLopHocContainer { get => pnlLopHocContainer; set => pnlLopHocContainer = value; }
        public Panel PnlGiaoDienLopHocContainer { get => pnlGiaoDienLopHocContainer; set => pnlGiaoDienLopHocContainer = value; }
    }
}