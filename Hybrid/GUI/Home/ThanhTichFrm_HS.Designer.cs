namespace Hybrid.GUI.Home
{
    partial class ThanhTichFrm_HS
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLoaiHoatDong = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbChuong = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvDanhSachHocSinh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiHoatDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chartArea1.AxisX.Title = "Bài kiểm tra";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chartArea1.AxisY.Title = "Điểm";
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
            series1.Name = "Điểm";
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(917, 653);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbLoaiHoatDong);
            this.panel1.Controls.Add(this.cbChuong);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 49);
            this.panel1.TabIndex = 5;
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
            this.cbChuong.Size = new System.Drawing.Size(729, 30);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Location = new System.Drawing.Point(8, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 50);
            this.panel2.TabIndex = 7;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 7);
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
            this.txtTimKiem.Text = "Tìm kiếm";
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
            // ThanhTichFrm_HS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 653);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThanhTichFrm_HS";
            this.Text = "ThanhTichForm_HS";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiHoatDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbLoaiHoatDong;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbChuong;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDanhSachHocSinh;
    }
}