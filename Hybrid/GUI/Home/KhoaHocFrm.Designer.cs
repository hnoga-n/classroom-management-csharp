using System.Windows.Forms;

namespace Hybrid.GUI.Home
{
    partial class KhoaHocFrm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnTaoChuong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.pnlChuongContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTaoChuong);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 70);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bài tập",
            "Bài kiểm tra",
            "Học liệu"});
            this.comboBox1.Location = new System.Drawing.Point(397, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Loại hoạt động";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.BackColor = System.Drawing.Color.White;
            this.lblTimKiem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.lblTimKiem.Location = new System.Drawing.Point(175, 22);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(94, 24);
            this.lblTimKiem.TabIndex = 4;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(163, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(218, 36);
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
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaoChuong
            // 
            this.btnTaoChuong.Location = new System.Drawing.Point(21, 13);
            this.btnTaoChuong.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaoChuong.Name = "btnTaoChuong";
            this.btnTaoChuong.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoChuong.OverrideDefault.Border.Rounding = 5;
            this.btnTaoChuong.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoChuong.Size = new System.Drawing.Size(120, 40);
            this.btnTaoChuong.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoChuong.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoChuong.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTaoChuong.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTaoChuong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoChuong.StateCommon.Border.Rounding = 5;
            this.btnTaoChuong.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnTaoChuong.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTaoChuong.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTaoChuong.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoChuong.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnTaoChuong.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnTaoChuong.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnTaoChuong.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTaoChuong.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaoChuong.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoChuong.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnTaoChuong.TabIndex = 1;
            this.btnTaoChuong.Values.Text = "Tạo chương";
            this.btnTaoChuong.Click += new System.EventHandler(this.btnTaoChuong_Click);
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // pnlChuongContainer
            // 
            this.pnlChuongContainer.AutoScroll = true;
            this.pnlChuongContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlChuongContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlChuongContainer.Name = "pnlChuongContainer";
            this.pnlChuongContainer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlChuongContainer.Size = new System.Drawing.Size(935, 600);
            this.pnlChuongContainer.TabIndex = 1;
            this.pnlChuongContainer.WrapContents = false;
            // 
            // KhoaHocFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 700);
            this.Controls.Add(this.pnlChuongContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhoaHocFrm";
            this.Text = "KhoaHocFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTaoChuong;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlChuongContainer;

        public FlowLayoutPanel PnlChuongContainer { get => pnlChuongContainer; set => pnlChuongContainer = value; }
    }
}