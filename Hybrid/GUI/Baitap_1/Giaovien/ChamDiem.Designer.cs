namespace Hybrid.GUI.Baitap
{
    partial class ChamDiem
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
            this.btnMark = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.state = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubmitTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.flowFilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.teacherComment = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContent = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(1223, 9);
            this.btnMark.Name = "btnMark";
            this.btnMark.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMark.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnMark.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMark.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Roboto Light", 10.2F);
            this.btnMark.Size = new System.Drawing.Size(151, 45);
            this.btnMark.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnMark.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnMark.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMark.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnMark.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMark.StateCommon.Border.Rounding = 5;
            this.btnMark.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMark.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnMark.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMark.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMark.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Roboto Light", 10.2F);
            this.btnMark.TabIndex = 8;
            this.btnMark.Values.Text = "Hoàn thành";
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.state.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.Red;
            this.state.Location = new System.Drawing.Point(122, 7);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(91, 20);
            this.state.TabIndex = 36;
            this.state.Text = "Đã kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Thông tin bài nộp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Điểm số";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(628, 83);
            this.score.MaxLength = 2;
            this.score.Multiline = false;
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(129, 114);
            this.score.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.score.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.score.StateCommon.Border.Rounding = 10;
            this.score.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.score.StateCommon.Content.Font = new System.Drawing.Font("Roboto Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 30, -1, -1);
            this.score.TabIndex = 33;
            this.score.Text = "";
            this.score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.score_KeyPress);
            this.score.KeyUp += new System.Windows.Forms.KeyEventHandler(this.score_KeyUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.state);
            this.panel1.Controls.Add(this.lblSubmitTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 114);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nộp vào lúc:";
            // 
            // lblSubmitTime
            // 
            this.lblSubmitTime.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitTime.Location = new System.Drawing.Point(4, 81);
            this.lblSubmitTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblSubmitTime.Name = "lblSubmitTime";
            this.lblSubmitTime.Size = new System.Drawing.Size(598, 23);
            this.lblSubmitTime.TabIndex = 30;
            this.lblSubmitTime.Text = "23:23 thứ 3 10/10";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(599, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bài làm của:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoEllipsis = true;
            this.lblStudent.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(4, 30);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(598, 23);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "hoanghuynguyen711@gmail.com";
            // 
            // flowFilePanel
            // 
            this.flowFilePanel.AutoScroll = true;
            this.flowFilePanel.BackColor = System.Drawing.Color.White;
            this.flowFilePanel.Location = new System.Drawing.Point(12, 687);
            this.flowFilePanel.Name = "flowFilePanel";
            this.flowFilePanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowFilePanel.Size = new System.Drawing.Size(1362, 65);
            this.flowFilePanel.TabIndex = 31;
            // 
            // teacherComment
            // 
            this.teacherComment.Location = new System.Drawing.Point(763, 83);
            this.teacherComment.MaxLength = 300;
            this.teacherComment.Name = "teacherComment";
            this.teacherComment.Size = new System.Drawing.Size(611, 114);
            this.teacherComment.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.teacherComment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.teacherComment.StateCommon.Border.Rounding = 10;
            this.teacherComment.StateCommon.Content.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherComment.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 8, -1, -1);
            this.teacherComment.TabIndex = 30;
            this.teacherComment.Tag = "";
            this.teacherComment.Text = "";
            this.teacherComment.TextChanged += new System.EventHandler(this.teacherComment_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1284, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nhận xét";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 203);
            this.txtContent.MaxLength = 4000;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(1362, 478);
            this.txtContent.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtContent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContent.StateCommon.Border.Rounding = 10;
            this.txtContent.StateCommon.Content.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 8, -1, -1);
            this.txtContent.TabIndex = 28;
            this.txtContent.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hybrid.Properties.Resources.icons8_homework_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(76, 9);
            this.lblTitle.MaximumSize = new System.Drawing.Size(1298, 48);
            this.lblTitle.MinimumSize = new System.Drawing.Size(0, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1141, 48);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Bài tập tuần 12:12";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaceholder.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceholder.Location = new System.Drawing.Point(790, 98);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(248, 24);
            this.lblPlaceholder.TabIndex = 36;
            this.lblPlaceholder.Text = "Viết nhận xét cho bài làm....";
            this.lblPlaceholder.Click += new System.EventHandler(this.lblPlaceholder_Click);
            // 
            // lblCharCount
            // 
            this.lblCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblCharCount.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCount.Location = new System.Drawing.Point(1154, 57);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(124, 23);
            this.lblCharCount.TabIndex = 37;
            this.lblCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 764);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowFilePanel);
            this.Controls.Add(this.teacherComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChamDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhgiaBaitap";
            this.Load += new System.EventHandler(this.ChamDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMark;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubmitTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.FlowLayoutPanel flowFilePanel;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox teacherComment;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlaceholder;
        private System.Windows.Forms.Label lblCharCount;
    }
}