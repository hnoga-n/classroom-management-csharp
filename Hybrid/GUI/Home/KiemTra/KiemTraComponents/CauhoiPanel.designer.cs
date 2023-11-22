namespace Hybrid.GUI.Kiemtra
{
    partial class CauhoiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauhoiPanel));
            this.order = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.question = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(15, 11);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(87, 20);
            this.order.TabIndex = 0;
            this.order.Text = "Câu hỏi 1:";
            // 
            // answer3
            // 
            this.answer3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3.ForeColor = System.Drawing.Color.Black;
            this.answer3.Location = new System.Drawing.Point(19, 279);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(1188, 65);
            this.answer3.TabIndex = 2;
            this.answer3.TabStop = true;
            this.answer3.Text = resources.GetString("answer3.Text");
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // answer1
            // 
            this.answer1.AutoEllipsis = true;
            this.answer1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.answer1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.answer1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.ForeColor = System.Drawing.Color.Black;
            this.answer1.Location = new System.Drawing.Point(19, 137);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(1188, 65);
            this.answer1.TabIndex = 3;
            this.answer1.TabStop = true;
            this.answer1.Text = resources.GetString("answer1.Text");
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // answer2
            // 
            this.answer2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2.ForeColor = System.Drawing.Color.Black;
            this.answer2.Location = new System.Drawing.Point(19, 208);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(1188, 65);
            this.answer2.TabIndex = 4;
            this.answer2.TabStop = true;
            this.answer2.Text = resources.GetString("answer2.Text");
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // answer4
            // 
            this.answer4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4.ForeColor = System.Drawing.Color.Black;
            this.answer4.Location = new System.Drawing.Point(19, 350);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(1188, 65);
            this.answer4.TabIndex = 6;
            this.answer4.TabStop = true;
            this.answer4.Text = resources.GetString("answer4.Text");
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(19, 34);
            this.question.MaxLength = 300;
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.Size = new System.Drawing.Size(1188, 82);
            this.question.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.question.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.question.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.question.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.question.StateCommon.Border.Rounding = 5;
            this.question.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.question.StateCommon.Content.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.TabIndex = 7;
            this.question.Text = resources.GetString("question.Text");
            // 
            // empty
            // 
            this.empty.AutoSize = true;
            this.empty.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empty.ForeColor = System.Drawing.Color.Red;
            this.empty.Location = new System.Drawing.Point(15, 418);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(310, 24);
            this.empty.TabIndex = 8;
            this.empty.Text = "Học sinh không chọn đáp án nào !";
            this.empty.Visible = false;
            // 
            // CauhoiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.empty);
            this.Controls.Add(this.question);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.order);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Name = "CauhoiPanel";
            this.Size = new System.Drawing.Size(1227, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label order;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer4;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox question;
        private System.Windows.Forms.Label empty;
    }
}
