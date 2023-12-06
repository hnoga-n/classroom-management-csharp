using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    partial class ThongTinLopHocFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinLopHocFrm));
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvDanhSachHocSinh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnXoaHocSinh = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTenGiaoVien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbNoiDung = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMaLop = new System.Windows.Forms.Panel();
            this.btnMoRong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCopy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRoiLop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoaLop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTenLop = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlMaLop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvDanhSachHocSinh);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 419);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(930, 332);
            this.panel5.TabIndex = 18;
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.AllowUserToAddRows = false;
            this.dgvDanhSachHocSinh.AllowUserToDeleteRows = false;
            this.dgvDanhSachHocSinh.AllowUserToResizeColumns = false;
            this.dgvDanhSachHocSinh.AllowUserToResizeRows = false;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachHocSinh.MultiSelect = false;
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.ReadOnly = true;
            this.dgvDanhSachHocSinh.RowHeadersVisible = false;
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachHocSinh.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 50;
            this.dgvDanhSachHocSinh.RowTemplate.ReadOnly = true;
            this.dgvDanhSachHocSinh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDanhSachHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(930, 332);
            this.dgvDanhSachHocSinh.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDanhSachHocSinh.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachHocSinh.TabIndex = 3;
            this.dgvDanhSachHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHocSinh_CellContentClick);
            // 
            // btnXoaHocSinh
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.btnXoaHocSinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnXoaHocSinh.HeaderText = "Xóa";
            this.btnXoaHocSinh.MinimumWidth = 6;
            this.btnXoaHocSinh.Name = "btnXoaHocSinh";
            this.btnXoaHocSinh.Text = "Xóa";
            this.btnXoaHocSinh.UseColumnTextForButtonValue = true;
            this.btnXoaHocSinh.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnXuatExcel);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.lblTenGiaoVien);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 313);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 106);
            this.panel4.TabIndex = 17;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Location = new System.Drawing.Point(700, 59);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnXuatExcel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnXuatExcel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.OverrideDefault.Border.Rounding = 5;
            this.btnXuatExcel.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.Size = new System.Drawing.Size(220, 40);
            this.btnXuatExcel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.StateCommon.Back.Image")));
            this.btnXuatExcel.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnXuatExcel.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.StateCommon.Border.Rounding = 5;
            this.btnXuatExcel.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 2, -1, -1);
            this.btnXuatExcel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXuatExcel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXuatExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatExcel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnXuatExcel.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnXuatExcel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnXuatExcel.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Values.Text = "Xuất danh sách lớp";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(11, 63);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(676, 36);
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
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.Text = "Tìm kiếm theo họ tên hoặc email hoặc sđt";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // lblTenGiaoVien
            // 
            this.lblTenGiaoVien.AutoSize = true;
            this.lblTenGiaoVien.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenGiaoVien.Location = new System.Drawing.Point(11, 28);
            this.lblTenGiaoVien.Name = "lblTenGiaoVien";
            this.lblTenGiaoVien.Size = new System.Drawing.Size(149, 28);
            this.lblTenGiaoVien.TabIndex = 1;
            this.lblTenGiaoVien.Text = "Tên giáo viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giáo viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.rtbNoiDung);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 169);
            this.panel3.TabIndex = 17;
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(12, 43);
            this.rtbNoiDung.MaxLength = 500;
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(908, 114);
            this.rtbNoiDung.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.rtbNoiDung.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.rtbNoiDung.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rtbNoiDung.StateCommon.Border.Rounding = 5;
            this.rtbNoiDung.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbNoiDung.TabIndex = 8;
            this.rtbNoiDung.Text = "";
            this.rtbNoiDung.Leave += new System.EventHandler(this.rtbNoiDung_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô tả";
            // 
            // pnlMaLop
            // 
            this.pnlMaLop.BackColor = System.Drawing.Color.White;
            this.pnlMaLop.Controls.Add(this.btnMoRong);
            this.pnlMaLop.Controls.Add(this.btnCopy);
            this.pnlMaLop.Controls.Add(this.txtMaLop);
            this.pnlMaLop.Controls.Add(this.label1);
            this.pnlMaLop.Location = new System.Drawing.Point(0, 80);
            this.pnlMaLop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMaLop.Name = "pnlMaLop";
            this.pnlMaLop.Size = new System.Drawing.Size(932, 64);
            this.pnlMaLop.TabIndex = 16;
            // 
            // btnMoRong
            // 
            this.btnMoRong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoRong.Location = new System.Drawing.Point(824, 11);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnMoRong.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnMoRong.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.Size = new System.Drawing.Size(45, 40);
            this.btnMoRong.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnMoRong.StateCommon.Back.Image")));
            this.btnMoRong.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnMoRong.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnMoRong.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnMoRong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StateCommon.Border.Rounding = 5;
            this.btnMoRong.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateCommon.Content.ShortText.Image = ((System.Drawing.Image)(resources.GetObject("btnMoRong.StateCommon.Content.ShortText.Image")));
            this.btnMoRong.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMoRong.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.TabIndex = 17;
            this.btnMoRong.Values.Text = "";
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Location = new System.Drawing.Point(875, 11);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnCopy.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnCopy.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnCopy.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnCopy.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnCopy.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCopy.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnCopy.Size = new System.Drawing.Size(45, 40);
            this.btnCopy.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCopy.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCopy.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.StateCommon.Back.Image")));
            this.btnCopy.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnCopy.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnCopy.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnCopy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCopy.StateCommon.Border.Rounding = 5;
            this.btnCopy.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnCopy.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnCopy.StateCommon.Content.ShortText.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.StateCommon.Content.ShortText.Image")));
            this.btnCopy.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnCopy.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnCopy.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCopy.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnCopy.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnCopy.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnCopy.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCopy.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnCopy.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnCopy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCopy.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnCopy.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnCopy.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnCopy.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnCopy.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnCopy.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCopy.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnCopy.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Values.Text = "";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.Color.White;
            this.txtMaLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLop.Location = new System.Drawing.Point(16, 30);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(802, 28);
            this.txtMaLop.TabIndex = 2;
            this.txtMaLop.TabStop = false;
            this.txtMaLop.Text = "Ma Lop Hoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRoiLop);
            this.panel1.Controls.Add(this.btnXoaLop);
            this.panel1.Controls.Add(this.txtTenLop);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnRoiLop
            // 
            this.btnRoiLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoiLop.Location = new System.Drawing.Point(875, 17);
            this.btnRoiLop.Name = "btnRoiLop";
            this.btnRoiLop.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnRoiLop.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnRoiLop.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnRoiLop.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnRoiLop.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnRoiLop.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRoiLop.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRoiLop.Size = new System.Drawing.Size(45, 40);
            this.btnRoiLop.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnRoiLop.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnRoiLop.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnRoiLop.StateCommon.Back.Image")));
            this.btnRoiLop.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnRoiLop.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnRoiLop.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnRoiLop.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRoiLop.StateCommon.Border.Rounding = 5;
            this.btnRoiLop.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnRoiLop.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnRoiLop.StateCommon.Content.ShortText.Image = ((System.Drawing.Image)(resources.GetObject("btnRoiLop.StateCommon.Content.ShortText.Image")));
            this.btnRoiLop.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnRoiLop.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnRoiLop.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRoiLop.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnRoiLop.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnRoiLop.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnRoiLop.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRoiLop.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnRoiLop.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnRoiLop.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRoiLop.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRoiLop.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRoiLop.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnRoiLop.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnRoiLop.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnRoiLop.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRoiLop.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRoiLop.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRoiLop.TabIndex = 18;
            this.btnRoiLop.Values.Text = "";
            this.btnRoiLop.Click += new System.EventHandler(this.btnRoiLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLop.Location = new System.Drawing.Point(875, 17);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnXoaLop.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnXoaLop.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnXoaLop.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnXoaLop.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnXoaLop.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaLop.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXoaLop.Size = new System.Drawing.Size(45, 40);
            this.btnXoaLop.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnXoaLop.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnXoaLop.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLop.StateCommon.Back.Image")));
            this.btnXoaLop.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnXoaLop.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.btnXoaLop.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnXoaLop.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaLop.StateCommon.Border.Rounding = 5;
            this.btnXoaLop.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnXoaLop.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnXoaLop.StateCommon.Content.ShortText.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLop.StateCommon.Content.ShortText.Image")));
            this.btnXoaLop.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnXoaLop.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnXoaLop.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaLop.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnXoaLop.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnXoaLop.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnXoaLop.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXoaLop.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnXoaLop.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnXoaLop.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaLop.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXoaLop.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnXoaLop.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnXoaLop.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnXoaLop.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnXoaLop.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoaLop.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnXoaLop.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnXoaLop.TabIndex = 17;
            this.btnXoaLop.Values.Text = "";
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.AlwaysActive = false;
            this.txtTenLop.Location = new System.Drawing.Point(93, 20);
            this.txtTenLop.MaxLength = 50;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(764, 36);
            this.txtTenLop.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtTenLop.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.txtTenLop.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.txtTenLop.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenLop.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTenLop.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTenLop.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtTenLop.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenLop.StateCommon.Border.Rounding = 5;
            this.txtTenLop.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLop.TabIndex = 14;
            this.txtTenLop.TabStop = false;
            this.txtTenLop.Leave += new System.EventHandler(this.txtTenLop_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.pnlMaLop);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(932, 753);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ThongTinLopHocFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThongTinLopHocFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin lớp học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongTinLopHocFrm_FormClosing);
            this.Load += new System.EventHandler(this.ThongTinLopHocFrm_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlMaLop.ResumeLayout(false);
            this.pnlMaLop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTenGiaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbNoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMaLop;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMoRong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCopy;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoaLop;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenLop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private DataGridViewButtonColumn btnXoaHocSinh;
        private KryptonButton btnRoiLop;
        private KryptonButton btnXuatExcel;
    }
}