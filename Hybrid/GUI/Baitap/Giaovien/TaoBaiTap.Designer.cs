namespace Hybrid.GUI.Baitap.Giaovien
{
    partial class TaoBaiTap
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
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.flowFilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChuong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpThoiGianBatDau = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpThoiGianKetThuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblCharCountContent = new System.Windows.Forms.Label();
            this.lblCharCountTitle = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(16, 65);
            this.txtTitle.MaxLength = 200;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1012, 54);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "";
            this.txtTitle.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề bài tập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung:";
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Location = new System.Drawing.Point(16, 165);
            this.txtContent.MaxLength = 4000;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(1012, 354);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // flowFilePanel
            // 
            this.flowFilePanel.BackColor = System.Drawing.Color.White;
            this.flowFilePanel.Location = new System.Drawing.Point(12, 576);
            this.flowFilePanel.Name = "flowFilePanel";
            this.flowFilePanel.Size = new System.Drawing.Size(1016, 100);
            this.flowFilePanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tải file bài tập:";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(141, 525);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(50, 45);
            this.btnUpload.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnUpload.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUpload.StateCommon.Back.Image = global::Hybrid.Properties.Resources.icons8_upload_30;
            this.btnUpload.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Values.Text = "";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.lblClass);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.lblChuong);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.lblTeacher);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.dtpThoiGianBatDau);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.dtpThoiGianKetThuc);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1034, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(266, 611);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp học:";
            // 
            // lblClass
            // 
            this.lblClass.AutoEllipsis = true;
            this.lblClass.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(3, 33);
            this.lblClass.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(263, 24);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Vật lý lý thuyết";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chương:";
            // 
            // lblChuong
            // 
            this.lblChuong.AutoEllipsis = true;
            this.lblChuong.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuong.Location = new System.Drawing.Point(3, 100);
            this.lblChuong.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblChuong.Name = "lblChuong";
            this.lblChuong.Size = new System.Drawing.Size(263, 24);
            this.lblChuong.TabIndex = 3;
            this.lblChuong.Text = "Chương 1";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giáo viên:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoEllipsis = true;
            this.lblTeacher.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(3, 167);
            this.lblTeacher.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(263, 24);
            this.lblTeacher.TabIndex = 5;
            this.lblTeacher.Text = "Nguyễn Huy Hoàng";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 201);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Bắt đầu lúc:";
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(3, 237);
            this.dtpThoiGianBatDau.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(263, 34);
            this.dtpThoiGianBatDau.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.dtpThoiGianBatDau.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.dtpThoiGianBatDau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpThoiGianBatDau.StateCommon.Border.Rounding = 5;
            this.dtpThoiGianBatDau.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiGianBatDau.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 281);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(320, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "Kết thúc vào:";
            // 
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(3, 317);
            this.dtpThoiGianKetThuc.MinDate = this.dtpThoiGianBatDau.Value;
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(263, 34);
            this.dtpThoiGianKetThuc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.dtpThoiGianKetThuc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.dtpThoiGianKetThuc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpThoiGianKetThuc.StateCommon.Border.Rounding = 5;
            this.dtpThoiGianKetThuc.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiGianKetThuc.TabIndex = 13;
            // 
            // lblCharCountContent
            // 
            this.lblCharCountContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCountContent.AutoSize = true;
            this.lblCharCountContent.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCharCountContent.Location = new System.Drawing.Point(924, 142);
            this.lblCharCountContent.Name = "lblCharCountContent";
            this.lblCharCountContent.Size = new System.Drawing.Size(65, 20);
            this.lblCharCountContent.TabIndex = 9;
            this.lblCharCountContent.Text = "0/4000";
            this.lblCharCountContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharCountTitle
            // 
            this.lblCharCountTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCountTitle.AutoSize = true;
            this.lblCharCountTitle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCharCountTitle.Location = new System.Drawing.Point(934, 42);
            this.lblCharCountTitle.Name = "lblCharCountTitle";
            this.lblCharCountTitle.Size = new System.Drawing.Size(55, 20);
            this.lblCharCountTitle.TabIndex = 8;
            this.lblCharCountTitle.Text = "0/200";
            this.lblCharCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(874, 525);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(154, 45);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 10;
            this.kryptonButton1.Values.Text = "Thêm đáp án";
            // 
            // TaoBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 732);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.lblCharCountContent);
            this.Controls.Add(this.lblCharCountTitle);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowFilePanel);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaoBaiTap";
            this.Text = "TaoBaiTap";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.FlowLayoutPanel flowFilePanel;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblChuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpThoiGianBatDau;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.Label lblCharCountContent;
        private System.Windows.Forms.Label lblCharCountTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}