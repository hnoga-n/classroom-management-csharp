using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Hybrid.GUI.Home.KiemTra.KiemTraComponents
{
    partial class PanelChiTietCauHoi
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
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.btnXoaCauHoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblDapAnDung = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlChiTietCauHoiContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNoiDung.Location = new System.Drawing.Point(32, 12);
            this.lblNoiDung.MaximumSize = new System.Drawing.Size(550, 100);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(539, 48);
            this.lblNoiDung.TabIndex = 6;
            this.lblNoiDung.Text = "Đây là tiêu đề của 1 câu hỏi có nội dung là 1 văn bản rất dài và dài";
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCauHoi.Location = new System.Drawing.Point(482, 13);
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
            this.btnXoaCauHoi.Size = new System.Drawing.Size(100, 40);
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
            this.btnXoaCauHoi.TabIndex = 11;
            this.btnXoaCauHoi.Values.Text = "Xóa";
            // 
            // lblDapAnDung
            // 
            this.lblDapAnDung.BackColor = System.Drawing.Color.LightGray;
            this.lblDapAnDung.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDapAnDung.ForeColor = System.Drawing.Color.Black;
            this.lblDapAnDung.Location = new System.Drawing.Point(12, 13);
            this.lblDapAnDung.MaximumSize = new System.Drawing.Size(600, 100);
            this.lblDapAnDung.Name = "lblDapAnDung";
            this.lblDapAnDung.Size = new System.Drawing.Size(426, 40);
            this.lblDapAnDung.TabIndex = 12;
            this.lblDapAnDung.Text = "Đáp án đúng: A";
            this.lblDapAnDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.lblDapAnDung);
            this.panel1.Controls.Add(this.btnXoaCauHoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 66);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNoiDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 100);
            this.panel2.TabIndex = 16;
            // 
            // pnlChiTietCauHoiContainer
            // 
            this.pnlChiTietCauHoiContainer.AutoSize = true;
            this.pnlChiTietCauHoiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTietCauHoiContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlChiTietCauHoiContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlChiTietCauHoiContainer.Name = "pnlChiTietCauHoiContainer";
            this.pnlChiTietCauHoiContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlChiTietCauHoiContainer.Size = new System.Drawing.Size(600, 284);
            this.pnlChiTietCauHoiContainer.TabIndex = 17;
            this.pnlChiTietCauHoiContainer.WrapContents = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Location = new System.Drawing.Point(482, 13);
            this.btnDong.Margin = new System.Windows.Forms.Padding(0);
            this.btnDong.Name = "btnDong";
            this.btnDong.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDong.OverrideDefault.Border.Rounding = 5;
            this.btnDong.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDong.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDong.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnDong.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnDong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDong.StateCommon.Border.Rounding = 5;
            this.btnDong.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.btnDong.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDong.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDong.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDong.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDong.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(98)))));
            this.btnDong.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDong.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDong.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDong.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(101)))));
            this.btnDong.TabIndex = 17;
            this.btnDong.Values.Text = "Đóng";
            this.btnDong.Visible = false;
            // 
            // PanelChiTietCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlChiTietCauHoiContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Name = "PanelChiTietCauHoi";
            this.Size = new System.Drawing.Size(600, 450);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoiDung;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoaCauHoi;
        private System.Windows.Forms.Label lblDapAnDung;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel pnlChiTietCauHoiContainer;
        private KryptonButton btnDong;

        public Label LblNoiDung { get => lblNoiDung; set => lblNoiDung = value; }
        public KryptonButton BtnXoaCauHoi { get => btnXoaCauHoi; set => btnXoaCauHoi = value; }
        public Label LblDapAnDung { get => lblDapAnDung; set => lblDapAnDung = value; }
        public FlowLayoutPanel PnlChiTietCauHoiContainer { get => pnlChiTietCauHoiContainer; set => pnlChiTietCauHoiContainer = value; }
        public KryptonButton BtnDong { get => btnDong; set => btnDong = value; }
    }
}
