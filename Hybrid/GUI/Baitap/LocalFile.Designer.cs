namespace Hybrid.GUI.Baitap
{
    partial class LocalFile
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
            this.btnLocalFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.fileName = new System.Windows.Forms.Label();
            this.btnRemoveFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalFile
            // 
            this.btnLocalFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLocalFile.Location = new System.Drawing.Point(0, 0);
            this.btnLocalFile.Name = "btnLocalFile";
            this.btnLocalFile.Size = new System.Drawing.Size(331, 56);
            this.btnLocalFile.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnLocalFile.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLocalFile.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnLocalFile.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLocalFile.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLocalFile.StateCommon.Border.Rounding = 10;
            this.btnLocalFile.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnLocalFile.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnLocalFile.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLocalFile.StateTracking.Border.Rounding = 10;
            this.btnLocalFile.TabIndex = 1;
            this.btnLocalFile.Values.Text = "";
            // 
            // fileName
            // 
            this.fileName.AutoEllipsis = true;
            this.fileName.BackColor = System.Drawing.Color.White;
            this.fileName.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(91, 16);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(184, 21);
            this.fileName.TabIndex = 3;
            this.fileName.Text = "test.xlsx";
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(281, 9);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(47, 37);
            this.btnRemoveFile.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnRemoveFile.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRemoveFile.StateCommon.Back.Image = global::Hybrid.Properties.Resources.icons8_close_30;
            this.btnRemoveFile.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnRemoveFile.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnRemoveFile.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRemoveFile.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveFile.TabIndex = 4;
            this.btnRemoveFile.Values.Text = "";
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Location = new System.Drawing.Point(31, 6);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 43);
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            // 
            // LocalFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.btnLocalFile);
            this.Name = "LocalFile";
            this.Size = new System.Drawing.Size(331, 56);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLocalFile;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label fileName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoveFile;
    }
}
