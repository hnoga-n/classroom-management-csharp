using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra
{
    partial class KiemTraFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCauHoiContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoaCauHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThemCauHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDang = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkDaoCauHoi = new System.Windows.Forms.CheckBox();
            this.chkCongKhaiDiem = new System.Windows.Forms.CheckBox();
            this.chkCongKhaiDapAn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpThoiGianKetThuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThoiGianBatDau = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlChiTietCauHoiContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDemKyTuTieuDeBaiKT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTieuDeBaiKT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlCauHoiContainer);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 753);
            this.panel1.TabIndex = 0;
            // 
            // pnlCauHoiContainer
            // 
            this.pnlCauHoiContainer.AutoScroll = true;
            this.pnlCauHoiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCauHoiContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCauHoiContainer.Location = new System.Drawing.Point(0, 117);
            this.pnlCauHoiContainer.Name = "pnlCauHoiContainer";
            this.pnlCauHoiContainer.Size = new System.Drawing.Size(420, 590);
            this.pnlCauHoiContainer.TabIndex = 7;
            this.pnlCauHoiContainer.WrapContents = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.checkBox4);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 707);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 46);
            this.panel6.TabIndex = 6;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(34, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xóa";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.panel4.Controls.Add(this.btnXoaCauHoi);
            this.panel4.Controls.Add(this.btnThemCauHoi);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 117);
            this.panel4.TabIndex = 4;
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Location = new System.Drawing.Point(226, 61);
            this.btnXoaCauHoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaCauHoi.Name = "btnXoaCauHoi";
            this.btnXoaCauHoi.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.OverrideDefault.Border.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaCauHoi.OverrideDefault.Border.Rounding = 5;
            this.btnXoaCauHoi.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoaCauHoi.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXoaCauHoi.OverrideFocus.Border.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.OverrideFocus.Border.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaCauHoi.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.Size = new System.Drawing.Size(180, 40);
            this.btnXoaCauHoi.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaCauHoi.StateCommon.Border.Rounding = 5;
            this.btnXoaCauHoi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnXoaCauHoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoaCauHoi.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXoaCauHoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaCauHoi.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnXoaCauHoi.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnXoaCauHoi.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnXoaCauHoi.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaCauHoi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Red;
            this.btnXoaCauHoi.TabIndex = 4;
            this.btnXoaCauHoi.Values.Text = "Xóa câu hỏi";
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(17, 61);
            this.btnThemCauHoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemCauHoi.OverrideDefault.Border.Rounding = 5;
            this.btnThemCauHoi.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemCauHoi.Size = new System.Drawing.Size(180, 40);
            this.btnThemCauHoi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThemCauHoi.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThemCauHoi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnThemCauHoi.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnThemCauHoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemCauHoi.StateCommon.Border.Rounding = 5;
            this.btnThemCauHoi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnThemCauHoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThemCauHoi.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThemCauHoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemCauHoi.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnThemCauHoi.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnThemCauHoi.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnThemCauHoi.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnThemCauHoi.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThemCauHoi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThemCauHoi.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnThemCauHoi.TabIndex = 3;
            this.btnThemCauHoi.Values.Text = "Thêm câu hỏi";
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(17, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(389, 36);
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
            this.txtTimKiem.Text = "Tìm kiếm câu hỏi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDang);
            this.panel2.Controls.Add(this.chkDaoCauHoi);
            this.panel2.Controls.Add(this.chkCongKhaiDiem);
            this.panel2.Controls.Add(this.chkCongKhaiDapAn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpThoiGianKetThuc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpThoiGianBatDau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1102, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 753);
            this.panel2.TabIndex = 1;
            // 
            // btnDang
            // 
            this.btnDang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDang.Location = new System.Drawing.Point(52, 704);
            this.btnDang.Margin = new System.Windows.Forms.Padding(0);
            this.btnDang.Name = "btnDang";
            this.btnDang.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDang.OverrideDefault.Border.Rounding = 5;
            this.btnDang.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDang.Size = new System.Drawing.Size(180, 40);
            this.btnDang.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDang.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDang.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnDang.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnDang.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDang.StateCommon.Border.Rounding = 5;
            this.btnDang.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnDang.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDang.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDang.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDang.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDang.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDang.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDang.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDang.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDang.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDang.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDang.TabIndex = 5;
            this.btnDang.Values.Text = "Đăng";
            // 
            // chkDaoCauHoi
            // 
            this.chkDaoCauHoi.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkDaoCauHoi.ForeColor = System.Drawing.Color.Black;
            this.chkDaoCauHoi.Location = new System.Drawing.Point(11, 351);
            this.chkDaoCauHoi.MaximumSize = new System.Drawing.Size(250, 100);
            this.chkDaoCauHoi.Name = "chkDaoCauHoi";
            this.chkDaoCauHoi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDaoCauHoi.Size = new System.Drawing.Size(250, 50);
            this.chkDaoCauHoi.TabIndex = 15;
            this.chkDaoCauHoi.Text = "Đảo câu hỏi";
            this.chkDaoCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDaoCauHoi.UseVisualStyleBackColor = true;
            // 
            // chkCongKhaiDiem
            // 
            this.chkCongKhaiDiem.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkCongKhaiDiem.ForeColor = System.Drawing.Color.Black;
            this.chkCongKhaiDiem.Location = new System.Drawing.Point(11, 275);
            this.chkCongKhaiDiem.MaximumSize = new System.Drawing.Size(250, 100);
            this.chkCongKhaiDiem.Name = "chkCongKhaiDiem";
            this.chkCongKhaiDiem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCongKhaiDiem.Size = new System.Drawing.Size(250, 70);
            this.chkCongKhaiDiem.TabIndex = 14;
            this.chkCongKhaiDiem.Text = "Công khai điểm sau khi nộp bài";
            this.chkCongKhaiDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCongKhaiDiem.UseVisualStyleBackColor = true;
            // 
            // chkCongKhaiDapAn
            // 
            this.chkCongKhaiDapAn.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkCongKhaiDapAn.ForeColor = System.Drawing.Color.Black;
            this.chkCongKhaiDapAn.Location = new System.Drawing.Point(11, 199);
            this.chkCongKhaiDapAn.MaximumSize = new System.Drawing.Size(250, 100);
            this.chkCongKhaiDapAn.Name = "chkCongKhaiDapAn";
            this.chkCongKhaiDapAn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCongKhaiDapAn.Size = new System.Drawing.Size(250, 70);
            this.chkCongKhaiDapAn.TabIndex = 13;
            this.chkCongKhaiDapAn.Text = "Công khai đáp án và giải thích";
            this.chkCongKhaiDapAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCongKhaiDapAn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(11, 144);
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(250, 34);
            this.dtpThoiGianKetThuc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.dtpThoiGianKetThuc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.dtpThoiGianKetThuc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpThoiGianKetThuc.StateCommon.Border.Rounding = 5;
            this.dtpThoiGianKetThuc.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiGianKetThuc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(11, 51);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(250, 34);
            this.dtpThoiGianBatDau.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.dtpThoiGianBatDau.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.dtpThoiGianBatDau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpThoiGianBatDau.StateCommon.Border.Rounding = 5;
            this.dtpThoiGianBatDau.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiGianBatDau.TabIndex = 0;
            this.dtpThoiGianBatDau.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlChiTietCauHoiContainer);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(420, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 753);
            this.panel3.TabIndex = 2;
            // 
            // pnlChiTietCauHoiContainer
            // 
            this.pnlChiTietCauHoiContainer.AutoScroll = true;
            this.pnlChiTietCauHoiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTietCauHoiContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlChiTietCauHoiContainer.Location = new System.Drawing.Point(0, 60);
            this.pnlChiTietCauHoiContainer.Name = "pnlChiTietCauHoiContainer";
            this.pnlChiTietCauHoiContainer.Padding = new System.Windows.Forms.Padding(35, 10, 0, 10);
            this.pnlChiTietCauHoiContainer.Size = new System.Drawing.Size(682, 693);
            this.pnlChiTietCauHoiContainer.TabIndex = 1;
            this.pnlChiTietCauHoiContainer.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblDemKyTuTieuDeBaiKT);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtTieuDeBaiKT);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(682, 60);
            this.panel5.TabIndex = 0;
            // 
            // lblDemKyTuTieuDeBaiKT
            // 
            this.lblDemKyTuTieuDeBaiKT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDemKyTuTieuDeBaiKT.AutoSize = true;
            this.lblDemKyTuTieuDeBaiKT.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDemKyTuTieuDeBaiKT.Location = new System.Drawing.Point(630, 20);
            this.lblDemKyTuTieuDeBaiKT.Name = "lblDemKyTuTieuDeBaiKT";
            this.lblDemKyTuTieuDeBaiKT.Size = new System.Drawing.Size(46, 20);
            this.lblDemKyTuTieuDeBaiKT.TabIndex = 6;
            this.lblDemKyTuTieuDeBaiKT.Text = "0/50";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiêu đề";
            // 
            // txtTieuDeBaiKT
            // 
            this.txtTieuDeBaiKT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTieuDeBaiKT.Location = new System.Drawing.Point(110, 12);
            this.txtTieuDeBaiKT.Name = "txtTieuDeBaiKT";
            this.txtTieuDeBaiKT.Size = new System.Drawing.Size(500, 36);
            this.txtTieuDeBaiKT.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.txtTieuDeBaiKT.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.txtTieuDeBaiKT.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTieuDeBaiKT.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTieuDeBaiKT.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtTieuDeBaiKT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTieuDeBaiKT.StateCommon.Border.Rounding = 5;
            this.txtTieuDeBaiKT.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTieuDeBaiKT.TabIndex = 4;
            this.txtTieuDeBaiKT.Text = "Vui lòng điền tiêu đề(trong vòng 50 ký tự)";
            this.txtTieuDeBaiKT.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // KiemTraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KiemTraFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Đề Kiểm Tra";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThemCauHoi;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTieuDeBaiKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDemKyTuTieuDeBaiKT;
        private System.Windows.Forms.FlowLayoutPanel pnlChiTietCauHoiContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpThoiGianBatDau;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpThoiGianKetThuc;
        private Label label2;
        private CheckBox chkDaoCauHoi;
        private CheckBox chkCongKhaiDiem;
        private CheckBox chkCongKhaiDapAn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoaCauHoi;
        private Panel panel6;
        private Label label4;
        private CheckBox checkBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDang;
        private FlowLayoutPanel pnlCauHoiContainer;

        public CheckBox ChkDaoCauHoi { get => chkDaoCauHoi; set => chkDaoCauHoi = value; }
        public CheckBox ChkCongKhaiDiem { get => chkCongKhaiDiem; set => chkCongKhaiDiem = value; }
        public CheckBox ChkCongKhaiDapAn { get => chkCongKhaiDapAn; set => chkCongKhaiDapAn = value; }
        public FlowLayoutPanel PnlChiTietCauHoiContainer { get => pnlChiTietCauHoiContainer; set => pnlChiTietCauHoiContainer = value; }
        public FlowLayoutPanel PnlCauHoiContainer { get => pnlCauHoiContainer; set => pnlCauHoiContainer = value; }
    }
}