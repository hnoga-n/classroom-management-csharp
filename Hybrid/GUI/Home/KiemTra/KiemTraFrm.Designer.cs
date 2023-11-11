using System;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemTraFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCauHoiContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkXoaToanBoCauHoi = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoaCauHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThemCauHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapNhat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDang = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkDaoCauHoi = new System.Windows.Forms.CheckBox();
            this.chkCongKhaiDiem = new System.Windows.Forms.CheckBox();
            this.chkCongKhaiDapAn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpThoiGianKetThuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpThoiGianBatDau = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel6.Controls.Add(this.chkXoaToanBoCauHoi);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 707);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 46);
            this.panel6.TabIndex = 6;
            // 
            // chkXoaToanBoCauHoi
            // 
            this.chkXoaToanBoCauHoi.AutoSize = true;
            this.chkXoaToanBoCauHoi.Location = new System.Drawing.Point(34, 2);
            this.chkXoaToanBoCauHoi.Name = "chkXoaToanBoCauHoi";
            this.chkXoaToanBoCauHoi.Size = new System.Drawing.Size(18, 17);
            this.chkXoaToanBoCauHoi.TabIndex = 22;
            this.chkXoaToanBoCauHoi.UseVisualStyleBackColor = true;
            this.chkXoaToanBoCauHoi.CheckedChanged += new System.EventHandler(this.chkXoaToanBoCauHoi_CheckedChanged);
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
            this.panel4.Controls.Add(this.btnTaiLai);
            this.panel4.Controls.Add(this.btnTimKiem);
            this.panel4.Controls.Add(this.btnXoaCauHoi);
            this.panel4.Controls.Add(this.btnThemCauHoi);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 117);
            this.panel4.TabIndex = 4;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiLai.Location = new System.Drawing.Point(366, 61);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaiLai.OverrideDefault.Border.Rounding = 5;
            this.btnTaiLai.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaiLai.Size = new System.Drawing.Size(40, 40);
            this.btnTaiLai.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaiLai.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaiLai.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.StateCommon.Back.Image")));
            this.btnTaiLai.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnTaiLai.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTaiLai.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTaiLai.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaiLai.StateCommon.Border.Rounding = 5;
            this.btnTaiLai.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnTaiLai.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTaiLai.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTaiLai.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiLai.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnTaiLai.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnTaiLai.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.StateTracking.Back.Image")));
            this.btnTaiLai.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaiLai.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTaiLai.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaiLai.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaiLai.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaiLai.TabIndex = 6;
            this.btnTaiLai.Values.Text = "";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Location = new System.Drawing.Point(366, 9);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.OverrideDefault.Border.Rounding = 5;
            this.btnTimKiem.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.Size = new System.Drawing.Size(40, 40);
            this.btnTimKiem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTimKiem.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTimKiem.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.StateCommon.Back.Image")));
            this.btnTimKiem.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnTimKiem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTimKiem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTimKiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StateCommon.Border.Rounding = 5;
            this.btnTimKiem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnTimKiem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTimKiem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTimKiem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnTimKiem.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnTimKiem.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.StateTracking.Back.Image")));
            this.btnTimKiem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTimKiem.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTimKiem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTimKiem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTimKiem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Values.Text = "";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCauHoi.Location = new System.Drawing.Point(203, 61);
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
            this.btnXoaCauHoi.Size = new System.Drawing.Size(150, 40);
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
            this.btnXoaCauHoi.Click += new System.EventHandler(this.btnXoaCauHoi_Click);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnThemCauHoi.Size = new System.Drawing.Size(150, 40);
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
            this.txtTimKiem.Size = new System.Drawing.Size(336, 36);
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
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.Text = "Tìm kiếm câu hỏi";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnCapNhat);
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(11, 415);
            this.label5.MaximumSize = new System.Drawing.Size(250, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 80);
            this.label5.TabIndex = 7;
            this.label5.Text = "* Chỉ có thể chỉnh sửa thời gian trước giờ bắt đầu kiểm tra 15 phút";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Location = new System.Drawing.Point(52, 704);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.OverrideDefault.Border.Rounding = 5;
            this.btnCapNhat.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.Size = new System.Drawing.Size(180, 40);
            this.btnCapNhat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnCapNhat.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnCapNhat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnCapNhat.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnCapNhat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.StateCommon.Border.Rounding = 5;
            this.btnCapNhat.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnCapNhat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnCapNhat.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCapNhat.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnCapNhat.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Values.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDang
            // 
            this.btnDang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDang.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnDang.Click += new System.EventHandler(this.btnDang_Click);
            // 
            // chkDaoCauHoi
            // 
            this.chkDaoCauHoi.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkDaoCauHoi.ForeColor = System.Drawing.Color.Black;
            this.chkDaoCauHoi.Location = new System.Drawing.Point(11, 350);
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
            this.chkCongKhaiDiem.Location = new System.Drawing.Point(11, 274);
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
            this.chkCongKhaiDapAn.Location = new System.Drawing.Point(11, 198);
            this.chkCongKhaiDapAn.MaximumSize = new System.Drawing.Size(250, 100);
            this.chkCongKhaiDapAn.Name = "chkCongKhaiDapAn";
            this.chkCongKhaiDapAn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCongKhaiDapAn.Size = new System.Drawing.Size(250, 70);
            this.chkCongKhaiDapAn.TabIndex = 13;
            this.chkCongKhaiDapAn.Text = "Công khai đáp án";
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
            this.dtpThoiGianKetThuc.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(11, 144);
            this.dtpThoiGianKetThuc.MinDate = this.dtpThoiGianBatDau.Value;
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
            this.dtpThoiGianKetThuc.Leave += new System.EventHandler(this.dtpThoiGianKetThuc_Leave);
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.CustomFormat = "dd/MM/yyyy HH:mm:ss";
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
            this.dtpThoiGianBatDau.Leave += new System.EventHandler(this.dtpThoiGianBatDau_Leave);
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
            this.lblDemKyTuTieuDeBaiKT.Location = new System.Drawing.Point(616, 21);
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
            this.txtTieuDeBaiKT.TextChanged += new System.EventHandler(this.txtTieuDeBaiKT_TextChanged);
            this.txtTieuDeBaiKT.Enter += new System.EventHandler(this.txtTieuDeBaiKT_Enter);
            this.txtTieuDeBaiKT.Leave += new System.EventHandler(this.txtTieuDeBaiKT_Leave);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KiemTraFrm_FormClosing);
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
        private CheckBox chkXoaToanBoCauHoi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDang;
        private FlowLayoutPanel pnlCauHoiContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTaiLai;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCapNhat;
        private Label label5;

        public CheckBox ChkDaoCauHoi { get => chkDaoCauHoi; set => chkDaoCauHoi = value; }
        public CheckBox ChkCongKhaiDiem { get => chkCongKhaiDiem; set => chkCongKhaiDiem = value; }
        public CheckBox ChkCongKhaiDapAn { get => chkCongKhaiDapAn; set => chkCongKhaiDapAn = value; }
        public FlowLayoutPanel PnlChiTietCauHoiContainer { get => pnlChiTietCauHoiContainer; set => pnlChiTietCauHoiContainer = value; }
        public FlowLayoutPanel PnlCauHoiContainer { get => pnlCauHoiContainer; set => pnlCauHoiContainer = value; }
    }
}