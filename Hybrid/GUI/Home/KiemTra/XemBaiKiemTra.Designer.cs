namespace Hybrid.GUI.Home.KiemTra
{
    partial class XemBaiKiemTra
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
            this.lblTitleExam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.navigatePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNumberQuestion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listcauhoipanel = new System.Windows.Forms.FlowLayoutPanel();
            this.navigatePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleExam
            // 
            this.lblTitleExam.AutoEllipsis = true;
            this.lblTitleExam.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleExam.Location = new System.Drawing.Point(41, 10);
            this.lblTitleExam.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleExam.Name = "lblTitleExam";
            this.lblTitleExam.Size = new System.Drawing.Size(1146, 53);
            this.lblTitleExam.TabIndex = 4;
            this.lblTitleExam.Text = "Bài kiểm tra giữa học kì 1";
            this.lblTitleExam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phiếu câu trả lời:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navigatePanel
            // 
            this.navigatePanel.BackColor = System.Drawing.Color.White;
            this.navigatePanel.Controls.Add(this.label2);
            this.navigatePanel.Location = new System.Drawing.Point(1249, 12);
            this.navigatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigatePanel.Name = "navigatePanel";
            this.navigatePanel.Size = new System.Drawing.Size(259, 774);
            this.navigatePanel.TabIndex = 5;
            // 
            // lblNumberQuestion
            // 
            this.lblNumberQuestion.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberQuestion.Location = new System.Drawing.Point(679, 63);
            this.lblNumberQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumberQuestion.Name = "lblNumberQuestion";
            this.lblNumberQuestion.Size = new System.Drawing.Size(112, 24);
            this.lblNumberQuestion.TabIndex = 8;
            this.lblNumberQuestion.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng câu hỏi:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTitleExam);
            this.panel2.Controls.Add(this.lblNumberQuestion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 104);
            this.panel2.TabIndex = 10;
            // 
            // listcauhoipanel
            // 
            this.listcauhoipanel.AutoScroll = true;
            this.listcauhoipanel.BackColor = System.Drawing.SystemColors.Control;
            this.listcauhoipanel.Location = new System.Drawing.Point(12, 123);
            this.listcauhoipanel.Margin = new System.Windows.Forms.Padding(0);
            this.listcauhoipanel.Name = "listcauhoipanel";
            this.listcauhoipanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listcauhoipanel.Size = new System.Drawing.Size(1227, 663);
            this.listcauhoipanel.TabIndex = 11;
            // 
            // XemBaiKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 795);
            this.Controls.Add(this.listcauhoipanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navigatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XemBaiKiemTra";
            this.Text = "XemBaiKiemTra";
            this.navigatePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel navigatePanel;
        private System.Windows.Forms.Label lblNumberQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel listcauhoipanel;
    }
}