namespace Hybrid.GUI.Baitap.Hocsinh
{
    partial class LamBaiTap
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
            this.question = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flowFileBaiTapPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChuong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNoiDungBaiLam = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            this.flowFileBaiLamPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.state = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.question);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.flowFileBaiTapPanel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDeadline);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblChuong);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 696);
            this.panel1.TabIndex = 3;
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(4, 166);
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.question.Size = new System.Drawing.Size(353, 259);
            this.question.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.question.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.question.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.question.StateCommon.Border.Rounding = 5;
            this.question.StateCommon.Content.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.TabIndex = 10;
            this.question.Text = "";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 33);
            this.label7.TabIndex = 9;
            this.label7.Text = "File bài tập:";
            // 
            // flowFileBaiTapPanel
            // 
            this.flowFileBaiTapPanel.AutoScroll = true;
            this.flowFileBaiTapPanel.Location = new System.Drawing.Point(0, 464);
            this.flowFileBaiTapPanel.Name = "flowFileBaiTapPanel";
            this.flowFileBaiTapPanel.Padding = new System.Windows.Forms.Padding(13, 0, 10, 0);
            this.flowFileBaiTapPanel.Size = new System.Drawing.Size(362, 232);
            this.flowFileBaiTapPanel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Câu hỏi:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hạn cuối:";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoEllipsis = true;
            this.lblDeadline.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(3, 94);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(356, 23);
            this.lblDeadline.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chương:";
            // 
            // lblChuong
            // 
            this.lblChuong.AutoEllipsis = true;
            this.lblChuong.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuong.Location = new System.Drawing.Point(4, 30);
            this.lblChuong.Name = "lblChuong";
            this.lblChuong.Size = new System.Drawing.Size(350, 23);
            this.lblChuong.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hybrid.Properties.Resources.icons8_homework_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtNoiDungBaiLam
            // 
            this.txtNoiDungBaiLam.Location = new System.Drawing.Point(380, 66);
            this.txtNoiDungBaiLam.MaxLength = 4000;
            this.txtNoiDungBaiLam.Name = "txtNoiDungBaiLam";
            this.txtNoiDungBaiLam.Size = new System.Drawing.Size(920, 514);
            this.txtNoiDungBaiLam.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtNoiDungBaiLam.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.txtNoiDungBaiLam.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNoiDungBaiLam.StateCommon.Border.Rounding = 5;
            this.txtNoiDungBaiLam.StateCommon.Content.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungBaiLam.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, 20, -1, -1);
            this.txtNoiDungBaiLam.TabIndex = 12;
            this.txtNoiDungBaiLam.Text = "";
            this.txtNoiDungBaiLam.TextChanged += new System.EventHandler(this.txtNoiDungBaiLam_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1136, 586);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSubmit.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSubmit.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Roboto Light", 10.2F);
            this.btnSubmit.Size = new System.Drawing.Size(164, 45);
            this.btnSubmit.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnSubmit.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSubmit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSubmit.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSubmit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StateCommon.Border.Rounding = 5;
            this.btnSubmit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSubmit.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnSubmit.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Roboto Light", 10.2F);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Values.Text = "Nộp bài";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "File bài làm:";
            // 
            // flowFileBaiLamPanel
            // 
            this.flowFileBaiLamPanel.AutoScroll = true;
            this.flowFileBaiLamPanel.BackColor = System.Drawing.Color.White;
            this.flowFileBaiLamPanel.Location = new System.Drawing.Point(380, 637);
            this.flowFileBaiLamPanel.Name = "flowFileBaiLamPanel";
            this.flowFileBaiLamPanel.Size = new System.Drawing.Size(920, 125);
            this.flowFileBaiLamPanel.TabIndex = 9;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(525, 586);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(50, 45);
            this.btnUpload.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnUpload.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUpload.StateCommon.Back.Image = global::Hybrid.Properties.Resources.icons8_upload_30;
            this.btnUpload.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Values.Text = "";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.state.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.Red;
            this.state.Location = new System.Drawing.Point(84, 39);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(91, 20);
            this.state.TabIndex = 25;
            this.state.Text = "Đã kết thúc";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(76, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1224, 48);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Bài tập 21/10";
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaceholder.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceholder.Location = new System.Drawing.Point(411, 92);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(195, 24);
            this.lblPlaceholder.TabIndex = 26;
            this.lblPlaceholder.Tag = "";
            this.lblPlaceholder.Text = "Viết đáp án vào đây...";
            this.lblPlaceholder.Click += new System.EventHandler(this.lblPlaceholder_Click);
            // 
            // lblCharCount
            // 
            this.lblCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCount.BackColor = System.Drawing.Color.White;
            this.lblCharCount.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCount.Location = new System.Drawing.Point(1176, 68);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(124, 30);
            this.lblCharCount.TabIndex = 27;
            this.lblCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LamBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 774);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.state);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.flowFileBaiLamPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNoiDungBaiLam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LamBaiTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuanop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LamBaiTap_FormClosing);
            this.Load += new System.EventHandler(this.LamBaiTap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowFileBaiTapPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChuong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtNoiDungBaiLam;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowFileBaiLamPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpload;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox question;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlaceholder;
        private System.Windows.Forms.Label lblCharCount;
    }
}