namespace Hybrid.GUI.Home.KiemTra
{
    partial class XemBaiLamHocSinh
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
            this.state = new System.Windows.Forms.Label();
            this.lblNumberQuestion = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rightAnswer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeSubmit = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.lblTitleExam = new System.Windows.Forms.Label();
            this.listcauhoipanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.navigatePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.listcauhoipanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.navigatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.state);
            this.panel1.Controls.Add(this.lblNumberQuestion);
            this.panel1.Controls.Add(this.score);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rightAnswer);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.timeSubmit);
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Location = new System.Drawing.Point(18, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 77);
            this.panel1.TabIndex = 15;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(97, 52);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(0, 20);
            this.state.TabIndex = 9;
            // 
            // lblNumberQuestion
            // 
            this.lblNumberQuestion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblNumberQuestion.Location = new System.Drawing.Point(710, 34);
            this.lblNumberQuestion.Name = "lblNumberQuestion";
            this.lblNumberQuestion.Size = new System.Drawing.Size(57, 38);
            this.lblNumberQuestion.TabIndex = 8;
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Black;
            this.score.Location = new System.Drawing.Point(1024, 8);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(141, 56);
            this.score.TabIndex = 7;
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(953, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Điểm:";
            // 
            // rightAnswer
            // 
            this.rightAnswer.AutoSize = true;
            this.rightAnswer.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAnswer.ForeColor = System.Drawing.Color.Black;
            this.rightAnswer.Location = new System.Drawing.Point(649, 19);
            this.rightAnswer.Name = "rightAnswer";
            this.rightAnswer.Size = new System.Drawing.Size(0, 39);
            this.rightAnswer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số câu đúng:";
            // 
            // timeSubmit
            // 
            this.timeSubmit.AutoSize = true;
            this.timeSubmit.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSubmit.Location = new System.Drawing.Point(97, 31);
            this.timeSubmit.Name = "timeSubmit";
            this.timeSubmit.Size = new System.Drawing.Size(0, 20);
            this.timeSubmit.TabIndex = 3;
            // 
            // studentName
            // 
            this.studentName.AutoEllipsis = true;
            this.studentName.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(97, 3);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(278, 26);
            this.studentName.TabIndex = 1;
            // 
            // avatar
            // 
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Location = new System.Drawing.Point(3, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(88, 74);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // lblTitleExam
            // 
            this.lblTitleExam.AutoEllipsis = true;
            this.lblTitleExam.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleExam.Location = new System.Drawing.Point(9, 9);
            this.lblTitleExam.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleExam.Name = "lblTitleExam";
            this.lblTitleExam.Size = new System.Drawing.Size(1336, 30);
            this.lblTitleExam.TabIndex = 14;
            this.lblTitleExam.Text = "Bài kiểm tra giữa học kì 1";
            // 
            // listcauhoipanel
            // 
            this.listcauhoipanel.AutoScroll = true;
            this.listcauhoipanel.BackColor = System.Drawing.Color.White;
            this.listcauhoipanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listcauhoipanel.Controls.Add(this.splitContainer1);
            this.listcauhoipanel.Location = new System.Drawing.Point(18, 123);
            this.listcauhoipanel.Margin = new System.Windows.Forms.Padding(0);
            this.listcauhoipanel.Name = "listcauhoipanel";
            this.listcauhoipanel.Size = new System.Drawing.Size(1327, 663);
            this.listcauhoipanel.TabIndex = 16;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(54, 0);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phiếu câu trả lời:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navigatePanel
            // 
            this.navigatePanel.BackColor = System.Drawing.Color.White;
            this.navigatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigatePanel.Controls.Add(this.label2);
            this.navigatePanel.Location = new System.Drawing.Point(1357, 42);
            this.navigatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigatePanel.Name = "navigatePanel";
            this.navigatePanel.Size = new System.Drawing.Size(181, 744);
            this.navigatePanel.TabIndex = 3;
            // 
            // XemBaiLamHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 795);
            this.Controls.Add(this.listcauhoipanel);
            this.Controls.Add(this.navigatePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitleExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XemBaiLamHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem bài làm kiểm tra";
            this.Load += new System.EventHandler(this.XemBaiLamHocSinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.listcauhoipanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.navigatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumberQuestion;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rightAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timeSubmit;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label lblTitleExam;
        private System.Windows.Forms.FlowLayoutPanel listcauhoipanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel navigatePanel;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}