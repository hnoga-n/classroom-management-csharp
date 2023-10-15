using System.Drawing;
using System.Windows.Forms;

namespace Hybrid
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalendar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnContacts = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTodo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnMinimizeForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCloseForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.btnCalendar);
            this.kryptonPanel1.Controls.Add(this.btnContacts);
            this.kryptonPanel1.Controls.Add(this.btnTodo);
            this.kryptonPanel1.Controls.Add(this.btnHome);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(100, 835);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalendar.Location = new System.Drawing.Point(0, 463);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalendar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.Size = new System.Drawing.Size(100, 60);
            this.btnCalendar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.StateCommon.Back.Image")));
            this.btnCalendar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.btnCalendar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalendar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 25, 5, 0);
            this.btnCalendar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCalendar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCalendar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCalendar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCalendar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCalendar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Values.Text = "Lịch học";
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(0, 403);
            this.btnContacts.Margin = new System.Windows.Forms.Padding(0);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContacts.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.Size = new System.Drawing.Size(100, 60);
            this.btnContacts.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnContacts.StateCommon.Back.Image")));
            this.btnContacts.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.btnContacts.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContacts.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 25, 5, 0);
            this.btnContacts.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnContacts.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnContacts.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnContacts.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContacts.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnContacts.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnContacts.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Values.Text = "Danh bạ";
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(0, 343);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTodo.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.Size = new System.Drawing.Size(100, 60);
            this.btnTodo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnTodo.StateCommon.Back.Image")));
            this.btnTodo.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.btnTodo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTodo.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 25, 5, 0);
            this.btnTodo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTodo.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTodo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTodo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTodo.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnTodo.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnTodo.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTodo.TabIndex = 3;
            this.btnTodo.Values.Text = "Todo";
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 283);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.Size = new System.Drawing.Size(100, 60);
            this.btnHome.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.StateCommon.Back.Image")));
            this.btnHome.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.btnHome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 25, 5, 0);
            this.btnHome.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHome.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnHome.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.TabIndex = 2;
            this.btnHome.Values.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.label1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(100, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1335, 45);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel2.StateNormal.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.StateNormal.Color2 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(616, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hybrid";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnMinimizeForm);
            this.kryptonPanel3.Controls.Add(this.btnCloseForm);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel3.Location = new System.Drawing.Point(1229, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(106, 45);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel3.TabIndex = 0;
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.Location = new System.Drawing.Point(18, 7);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMinimizeForm.OverrideDefault.Border.Rounding = 12;
            this.btnMinimizeForm.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMinimizeForm.OverrideFocus.Border.Rounding = 12;
            this.btnMinimizeForm.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizeForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMinimizeForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnMinimizeForm.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMinimizeForm.StateCommon.Border.Rounding = 20;
            this.btnMinimizeForm.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeForm.StateNormal.Back.Image")));
            this.btnMinimizeForm.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMinimizeForm.StateNormal.Border.Rounding = 20;
            this.btnMinimizeForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMinimizeForm.StatePressed.Border.Rounding = 20;
            this.btnMinimizeForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeForm.StateTracking.Back.Image")));
            this.btnMinimizeForm.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnMinimizeForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMinimizeForm.StateTracking.Border.Rounding = 20;
            this.btnMinimizeForm.TabIndex = 3;
            this.btnMinimizeForm.Values.Text = "";
            this.btnMinimizeForm.Click += new System.EventHandler(this.btnMinimizeForm_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(59, 7);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.Size = new System.Drawing.Size(35, 35);
            this.btnCloseForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCloseForm.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.StateCommon.Back.Image")));
            this.btnCloseForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnCloseForm.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCloseForm.StateCommon.Border.Rounding = 20;
            this.btnCloseForm.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCloseForm.StateNormal.Border.Rounding = 20;
            this.btnCloseForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCloseForm.StatePressed.Border.Rounding = 20;
            this.btnCloseForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.StateTracking.Back.Image")));
            this.btnCloseForm.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnCloseForm.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnCloseForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCloseForm.StateTracking.Border.Rounding = 20;
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.Values.Text = "";
            this.btnCloseForm.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(100, 45);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1335, 790);
            this.pnlContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 835);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 12;
            this.StateActive.Border.Width = 0;
            this.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.StateCommon.Border.Width = 0;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Border.Rounding = 12;
            this.StateInactive.Border.Width = 0;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCloseForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMinimizeForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCalendar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnContacts;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTodo;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

