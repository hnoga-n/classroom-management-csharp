namespace Hybrid.GUI.Home
{
    partial class ThemChuongFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenChuong = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDemKyTuTenChuong = new System.Windows.Forms.Label();
            this.btnTaoChuong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCapNhat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chương";
            // 
            // txtTenChuong
            // 
            this.txtTenChuong.AlwaysActive = false;
            this.txtTenChuong.Location = new System.Drawing.Point(12, 43);
            this.txtTenChuong.Name = "txtTenChuong";
            this.txtTenChuong.Size = new System.Drawing.Size(509, 36);
            this.txtTenChuong.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtTenChuong.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.txtTenChuong.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.txtTenChuong.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenChuong.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.txtTenChuong.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTenChuong.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtTenChuong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenChuong.StateCommon.Border.Rounding = 5;
            this.txtTenChuong.StateCommon.Content.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenChuong.TabIndex = 3;
            this.txtTenChuong.TabStop = false;
            this.txtTenChuong.Text = "Vui lòng điền tên chương(trong vòng 50 ký tự)";
            this.txtTenChuong.TextChanged += new System.EventHandler(this.txtTenChuong_TextChanged);
            this.txtTenChuong.Enter += new System.EventHandler(this.txtTenChuong_Enter);
            this.txtTenChuong.Leave += new System.EventHandler(this.txtTenChuong_Leave);
            // 
            // lblDemKyTuTenChuong
            // 
            this.lblDemKyTuTenChuong.AutoSize = true;
            this.lblDemKyTuTenChuong.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDemKyTuTenChuong.Location = new System.Drawing.Point(524, 51);
            this.lblDemKyTuTenChuong.Name = "lblDemKyTuTenChuong";
            this.lblDemKyTuTenChuong.Size = new System.Drawing.Size(46, 20);
            this.lblDemKyTuTenChuong.TabIndex = 4;
            this.lblDemKyTuTenChuong.Text = "0/50";
            // 
            // btnTaoChuong
            // 
            this.btnTaoChuong.Location = new System.Drawing.Point(229, 100);
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
            this.btnTaoChuong.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTaoChuong.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnTaoChuong.TabIndex = 5;
            this.btnTaoChuong.Values.Text = "Đăng lên";
            this.btnTaoChuong.Click += new System.EventHandler(this.btnTaoChuong_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Location = new System.Drawing.Point(229, 100);
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
            this.btnCapNhat.Size = new System.Drawing.Size(120, 40);
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
            this.btnCapNhat.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnCapNhat.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Values.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // ThemChuongFrm
            // 
            this.AcceptButton = this.btnTaoChuong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 149);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTaoChuong);
            this.Controls.Add(this.lblDemKyTuTenChuong);
            this.Controls.Add(this.txtTenChuong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemChuongFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo chương mới";
            this.Deactivate += new System.EventHandler(this.ThemChuongFrm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTenChuong;
        private System.Windows.Forms.Label lblDemKyTuTenChuong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTaoChuong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCapNhat;
    }
}