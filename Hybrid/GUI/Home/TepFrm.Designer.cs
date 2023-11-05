namespace Hybrid.GUI.Home
{
    partial class TepFrm
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
            this.lblClassName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.Location = new System.Drawing.Point(428, 322);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(69, 42);
            this.lblClassName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblClassName.StateCommon.ShortText.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Values.Text = "Tệp";
            // 
            // TepFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 700);
            this.Controls.Add(this.lblClassName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TepFrm";
            this.Text = "TepFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblClassName;
    }
}