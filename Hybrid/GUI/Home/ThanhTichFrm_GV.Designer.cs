using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hybrid.GUI.Home
{
    partial class ThanhTichFrm_GV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhTichFrm_GV));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHoatDong = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbLoaiHoatDong = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbChuong = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvDanhSachHocSinh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHoatDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiHoatDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.dgvDanhSachHocSinh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(935, 700);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbHoatDong);
            this.panel1.Controls.Add(this.cbLoaiHoatDong);
            this.panel1.Controls.Add(this.cbChuong);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 49);
            this.panel1.TabIndex = 5;
            // 
            // cbHoatDong
            // 
            this.cbHoatDong.AlwaysActive = false;
            this.cbHoatDong.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.cbHoatDong.DropDownHeight = 500;
            this.cbHoatDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoatDong.DropDownWidth = 180;
            this.cbHoatDong.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cbHoatDong.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.cbHoatDong.Location = new System.Drawing.Point(537, 9);
            this.cbHoatDong.Name = "cbHoatDong";
            this.cbHoatDong.Size = new System.Drawing.Size(363, 30);
            this.cbHoatDong.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbHoatDong.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cbHoatDong.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbHoatDong.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHoatDong.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbHoatDong.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbHoatDong.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbHoatDong.StateCommon.Item.Back.Color2 = System.Drawing.SystemColors.Control;
            this.cbHoatDong.StateCommon.Item.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.cbHoatDong.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbHoatDong.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbHoatDong.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbHoatDong.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbHoatDong.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHoatDong.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbHoatDong.TabIndex = 8;
            this.cbHoatDong.SelectedIndexChanged += new System.EventHandler(this.cbHoatDong_SelectedIndexChanged);
            // 
            // cbLoaiHoatDong
            // 
            this.cbLoaiHoatDong.AlwaysActive = false;
            this.cbLoaiHoatDong.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.cbLoaiHoatDong.DropDownHeight = 500;
            this.cbLoaiHoatDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHoatDong.DropDownWidth = 180;
            this.cbLoaiHoatDong.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cbLoaiHoatDong.Items.AddRange(new object[] {
            "Bài kiểm tra",
            "Bài tập"});
            this.cbLoaiHoatDong.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.cbLoaiHoatDong.Location = new System.Drawing.Point(12, 9);
            this.cbLoaiHoatDong.Name = "cbLoaiHoatDong";
            this.cbLoaiHoatDong.Size = new System.Drawing.Size(150, 30);
            this.cbLoaiHoatDong.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbLoaiHoatDong.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cbLoaiHoatDong.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbLoaiHoatDong.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiHoatDong.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbLoaiHoatDong.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbLoaiHoatDong.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbLoaiHoatDong.StateCommon.Item.Back.Color2 = System.Drawing.SystemColors.Control;
            this.cbLoaiHoatDong.StateCommon.Item.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.cbLoaiHoatDong.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbLoaiHoatDong.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbLoaiHoatDong.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbLoaiHoatDong.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbLoaiHoatDong.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiHoatDong.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbLoaiHoatDong.TabIndex = 7;
            this.cbLoaiHoatDong.Text = "Bài kiểm tra";
            this.cbLoaiHoatDong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHoatDong_SelectedIndexChanged);
            // 
            // cbChuong
            // 
            this.cbChuong.AlwaysActive = false;
            this.cbChuong.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.cbChuong.DropDownHeight = 500;
            this.cbChuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuong.DropDownWidth = 180;
            this.cbChuong.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cbChuong.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.cbChuong.Location = new System.Drawing.Point(168, 9);
            this.cbChuong.Name = "cbChuong";
            this.cbChuong.Size = new System.Drawing.Size(363, 30);
            this.cbChuong.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbChuong.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cbChuong.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbChuong.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChuong.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cbChuong.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cbChuong.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cbChuong.StateCommon.Item.Back.Color2 = System.Drawing.SystemColors.Control;
            this.cbChuong.StateCommon.Item.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear33;
            this.cbChuong.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbChuong.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbChuong.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbChuong.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbChuong.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChuong.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbChuong.TabIndex = 0;
            this.cbChuong.SelectedIndexChanged += new System.EventHandler(this.cbChuong_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Điểm";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chartArea1.AxisY.Title = "Số lượng học sinh";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Số lượng học sinh";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(917, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Roboto Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            title1.Text = "PHỔ ĐIỂM";
            this.chart1.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Location = new System.Drawing.Point(8, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 50);
            this.panel2.TabIndex = 7;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Location = new System.Drawing.Point(12, 5);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.OverrideDefault.Border.Rounding = 5;
            this.btnXuatExcel.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnXuatExcel.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatExcel.Size = new System.Drawing.Size(150, 40);
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
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Values.Text = "Xuất excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(286, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(500, 36);
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
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.Text = "Tìm kiếm theo tên học sinh";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.AllowUserToAddRows = false;
            this.dgvDanhSachHocSinh.AllowUserToDeleteRows = false;
            this.dgvDanhSachHocSinh.AllowUserToResizeColumns = false;
            this.dgvDanhSachHocSinh.AllowUserToResizeRows = false;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(8, 425);
            this.dgvDanhSachHocSinh.MultiSelect = false;
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.ReadOnly = true;
            this.dgvDanhSachHocSinh.RowHeadersVisible = false;
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 30;
            this.dgvDanhSachHocSinh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDanhSachHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(915, 310);
            this.dgvDanhSachHocSinh.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDanhSachHocSinh.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvDanhSachHocSinh.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvDanhSachHocSinh.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgvDanhSachHocSinh.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachHocSinh.TabIndex = 8;
            // 
            // ThanhTichFrm_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 700);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(0, 700);
            this.Name = "ThanhTichFrm_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ThanhTichFrm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbHoatDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiHoatDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbHoatDong;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbLoaiHoatDong;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbChuong;
        private Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDanhSachHocSinh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXuatExcel;
    }
}