namespace Hybrid.GUI.Baitap
{
    partial class CloudFile
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
            this.btnCloudFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.fileName = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloudFile
            // 
            this.btnCloudFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloudFile.Location = new System.Drawing.Point(0, 0);
            this.btnCloudFile.Name = "btnCloudFile";
            this.btnCloudFile.Size = new System.Drawing.Size(331, 56);
            this.btnCloudFile.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCloudFile.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCloudFile.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnCloudFile.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCloudFile.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCloudFile.StateCommon.Border.Rounding = 10;
            this.btnCloudFile.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnCloudFile.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCloudFile.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCloudFile.StateTracking.Border.Rounding = 10;
            this.btnCloudFile.TabIndex = 2;
            this.btnCloudFile.Values.Text = "";
            this.btnCloudFile.Click += new System.EventHandler(this.btnCloudFile_Click);
            // 
            // fileName
            // 
            this.fileName.AutoEllipsis = true;
            this.fileName.BackColor = System.Drawing.Color.White;
            this.fileName.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(103, 17);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(225, 21);
            this.fileName.TabIndex = 5;
            this.fileName.Text = "test.xlsx";
            this.fileName.Click += new System.EventHandler(this.fileName_Click);
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(43, 7);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 43);
            this.icon.TabIndex = 4;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // CloudFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.btnCloudFile);
            this.Name = "CloudFile";
            this.Size = new System.Drawing.Size(331, 56);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCloudFile;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.PictureBox icon;
    }
}
