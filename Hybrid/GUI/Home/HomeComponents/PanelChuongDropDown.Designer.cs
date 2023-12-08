using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    partial class PanelChuongDropDown
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelChuongDropDown));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDemTaiLieuChuong = new System.Windows.Forms.Label();
            this.btnXoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuThem = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.lblTenChuong = new System.Windows.Forms.Label();
            this.btnMoRong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlChuongComponent = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.timerHieuUngDropDown = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDemTaiLieuChuong);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblTenChuong);
            this.panel1.Controls.Add(this.btnMoRong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 80);
            this.panel1.TabIndex = 1;
            // 
            // lblDemTaiLieuChuong
            // 
            this.lblDemTaiLieuChuong.AutoSize = true;
            this.lblDemTaiLieuChuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDemTaiLieuChuong.Location = new System.Drawing.Point(32, 1);
            this.lblDemTaiLieuChuong.Name = "lblDemTaiLieuChuong";
            this.lblDemTaiLieuChuong.Size = new System.Drawing.Size(30, 20);
            this.lblDemTaiLieuChuong.TabIndex = 14;
            this.lblDemTaiLieuChuong.Text = "(0)";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(844, 19);
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
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Values.Text = "";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(799, 19);
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
            this.btnSua.TabIndex = 12;
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.KryptonContextMenu = this.menuThem;
            this.btnThem.Location = new System.Drawing.Point(752, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnThem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnThem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnThem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.StateCommon.Back.Image")));
            this.btnThem.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnThem.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnThem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateCommon.Border.Rounding = 5;
            this.btnThem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnThem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnThem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThem.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnThem.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnThem.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThem.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnThem.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnThem.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThem.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnThem.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnThem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnThem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnThem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnThem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnThem.TabIndex = 11;
            this.btnThem.Values.Text = "";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // menuThem
            // 
            this.menuThem.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            this.menuThem.StateCommon.ControlInner.Back.Color1 = System.Drawing.Color.White;
            this.menuThem.StateCommon.ControlInner.Back.Color2 = System.Drawing.Color.White;
            this.menuThem.StateCommon.ControlInner.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menuThem.StateCommon.ControlInner.Border.Rounding = 5;
            this.menuThem.StateCommon.ControlOuter.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.menuThem.StateCommon.ControlOuter.Border.Rounding = 5;
            this.menuThem.StateNormal.ItemTextAlternate.ShortText.Color1 = System.Drawing.Color.Black;
            this.menuThem.StateNormal.ItemTextAlternate.ShortText.Color2 = System.Drawing.Color.Black;
            this.menuThem.StateNormal.ItemTextAlternate.ShortText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuSeparator1,
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuSeparator2,
            this.kryptonContextMenuItem3});
            this.kryptonContextMenuItems1.StandardStyle = false;
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonContextMenuItem1.Image")));
            this.kryptonContextMenuItem1.StateHighlight.ItemHighlight.Back.Color1 = System.Drawing.Color.White;
            this.kryptonContextMenuItem1.StateHighlight.ItemHighlight.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonContextMenuItem1.StateHighlight.ItemHighlight.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonContextMenuItem1.StateHighlight.ItemHighlight.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonContextMenuItem1.StateHighlight.ItemHighlight.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonContextMenuItem1.Text = "Bài tập";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonContextMenuItem2.Image")));
            this.kryptonContextMenuItem2.StateHighlight.ItemHighlight.Back.Color1 = System.Drawing.Color.White;
            this.kryptonContextMenuItem2.StateHighlight.ItemHighlight.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonContextMenuItem2.StateHighlight.ItemHighlight.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonContextMenuItem2.StateHighlight.ItemHighlight.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonContextMenuItem2.StateHighlight.ItemHighlight.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonContextMenuItem2.Text = "Bài kiểm tra";
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("kryptonContextMenuItem3.Image")));
            this.kryptonContextMenuItem3.StateHighlight.ItemHighlight.Back.Color1 = System.Drawing.Color.White;
            this.kryptonContextMenuItem3.StateHighlight.ItemHighlight.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonContextMenuItem3.StateHighlight.ItemHighlight.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonContextMenuItem3.StateHighlight.ItemHighlight.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonContextMenuItem3.StateHighlight.ItemHighlight.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonContextMenuItem3.Text = "Học liệu";
            // 
            // lblTenChuong
            // 
            this.lblTenChuong.AutoSize = true;
            this.lblTenChuong.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenChuong.ForeColor = System.Drawing.Color.Black;
            this.lblTenChuong.Location = new System.Drawing.Point(72, 27);
            this.lblTenChuong.Name = "lblTenChuong";
            this.lblTenChuong.Size = new System.Drawing.Size(112, 28);
            this.lblTenChuong.TabIndex = 10;
            this.lblTenChuong.Text = "Chương 1";
            // 
            // btnMoRong
            // 
            this.btnMoRong.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnMoRong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoRong.Location = new System.Drawing.Point(31, 24);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.Size = new System.Drawing.Size(35, 35);
            this.btnMoRong.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnMoRong.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnMoRong.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StateCommon.Border.Rounding = 5;
            this.btnMoRong.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.btnMoRong.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMoRong.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMoRong.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.TabIndex = 9;
            this.btnMoRong.Values.Text = "▼";
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // pnlChuongComponent
            // 
            this.pnlChuongComponent.AutoScroll = true;
            this.pnlChuongComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChuongComponent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlChuongComponent.Location = new System.Drawing.Point(0, 80);
            this.pnlChuongComponent.Name = "pnlChuongComponent";
            this.pnlChuongComponent.Size = new System.Drawing.Size(900, 0);
            this.pnlChuongComponent.TabIndex = 2;
            this.pnlChuongComponent.WrapContents = false;
            // 
            // timerHieuUngDropDown
            // 
            this.timerHieuUngDropDown.Tick += new System.EventHandler(this.timerHieuUngDropDown_Tick);
            // 
            // PanelChuongDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlChuongComponent);
            this.Controls.Add(this.panel1);
            this.Name = "PanelChuongDropDown";
            this.Size = new System.Drawing.Size(900, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        

        #endregion

        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMoRong;
        private FlowLayoutPanel pnlChuongComponent;
        private Label lblDemTaiLieuChuong;
        private KryptonContextMenu menuThem;
        private KryptonContextMenuItems kryptonContextMenuItems1;
        private KryptonContextMenuItem kryptonContextMenuItem1;
        private KryptonContextMenuItem kryptonContextMenuItem2;
        private KryptonContextMenuItem kryptonContextMenuItem3;
        private KryptonContextMenuItems kryptonContextMenuItems2;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator2;
        private Label lblTenChuong;
        private Timer timerHieuUngDropDown;

        public KryptonButton BtnXoa { get => btnXoa; set => btnXoa = value; }
        public KryptonButton BtnThem { get => btnThem; set => btnThem = value; }
        public FlowLayoutPanel PnlChuongComponent { get => pnlChuongComponent; set => pnlChuongComponent = value; }
        public Label LblDemTaiLieuChuong { get => lblDemTaiLieuChuong; set => lblDemTaiLieuChuong = value; }
        public KryptonButton BtnSua { get => btnSua; set => btnSua = value; }
        public Label LblTenChuong { get => lblTenChuong; set => lblTenChuong = value; }
    }
}
