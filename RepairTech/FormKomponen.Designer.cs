﻿namespace PROJECT_PBO
{
    partial class FormKomponen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKomponen));
            sidebar = new FlowLayoutPanel();
            panelSidebar = new Panel();
            label1 = new Label();
            buttonMenu = new PictureBox();
            panel1 = new Panel();
            buttonTransaksi = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            buttonKomponen = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            buttonJasa = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            buttonTeknisi = new FontAwesome.Sharp.IconButton();
            timerSidebar = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            sidebar.SuspendLayout();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 30, 68);
            sidebar.Controls.Add(panelSidebar);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(165, 620);
            sidebar.MinimumSize = new Size(53, 620);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(165, 620);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 30, 68);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(buttonMenu);
            panelSidebar.Location = new Point(3, 3);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(190, 100);
            panelSidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(63, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // buttonMenu
            // 
            buttonMenu.Cursor = Cursors.Hand;
            buttonMenu.Image = (Image)resources.GetObject("buttonMenu.Image");
            buttonMenu.Location = new Point(3, 26);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(38, 40);
            buttonMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonMenu.TabIndex = 1;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(buttonTransaksi);
            panel1.Location = new Point(3, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 51);
            panel1.TabIndex = 5;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.BackColor = Color.FromArgb(31, 30, 68);
            buttonTransaksi.FlatAppearance.BorderSize = 0;
            buttonTransaksi.FlatStyle = FlatStyle.Flat;
            buttonTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTransaksi.ForeColor = SystemColors.Control;
            buttonTransaksi.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            buttonTransaksi.IconColor = SystemColors.Control;
            buttonTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTransaksi.IconSize = 32;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(-1, 3);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Size = new Size(147, 41);
            buttonTransaksi.TabIndex = 1;
            buttonTransaksi.Text = "Transaksi";
            buttonTransaksi.TextAlign = ContentAlignment.MiddleRight;
            buttonTransaksi.UseVisualStyleBackColor = false;
            buttonTransaksi.Click += buttonTransaksi_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 68);
            panel2.Controls.Add(buttonKomponen);
            panel2.Location = new Point(3, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 51);
            panel2.TabIndex = 5;
            // 
            // buttonKomponen
            // 
            buttonKomponen.BackColor = Color.FromArgb(31, 30, 68);
            buttonKomponen.FlatAppearance.BorderSize = 0;
            buttonKomponen.FlatStyle = FlatStyle.Flat;
            buttonKomponen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKomponen.ForeColor = SystemColors.Control;
            buttonKomponen.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            buttonKomponen.IconColor = Color.White;
            buttonKomponen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonKomponen.IconSize = 32;
            buttonKomponen.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKomponen.Location = new Point(0, 3);
            buttonKomponen.Name = "buttonKomponen";
            buttonKomponen.Size = new Size(162, 41);
            buttonKomponen.TabIndex = 1;
            buttonKomponen.Text = "Komponen";
            buttonKomponen.TextAlign = ContentAlignment.MiddleRight;
            buttonKomponen.UseVisualStyleBackColor = false;
            buttonKomponen.Click += buttonKomponen_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonJasa);
            panel3.Location = new Point(3, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 51);
            panel3.TabIndex = 5;
            // 
            // buttonJasa
            // 
            buttonJasa.BackColor = Color.FromArgb(31, 30, 68);
            buttonJasa.FlatAppearance.BorderSize = 0;
            buttonJasa.FlatStyle = FlatStyle.Flat;
            buttonJasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJasa.ForeColor = SystemColors.Control;
            buttonJasa.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            buttonJasa.IconColor = SystemColors.Control;
            buttonJasa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonJasa.IconSize = 32;
            buttonJasa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonJasa.Location = new Point(0, 3);
            buttonJasa.Name = "buttonJasa";
            buttonJasa.Size = new Size(159, 41);
            buttonJasa.TabIndex = 1;
            buttonJasa.Text = "Jasa Servis";
            buttonJasa.TextAlign = ContentAlignment.MiddleRight;
            buttonJasa.UseVisualStyleBackColor = false;
            buttonJasa.Click += buttonJasa_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonTeknisi);
            panel4.Location = new Point(3, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(162, 51);
            panel4.TabIndex = 5;
            // 
            // buttonTeknisi
            // 
            buttonTeknisi.BackColor = Color.FromArgb(31, 30, 68);
            buttonTeknisi.FlatAppearance.BorderSize = 0;
            buttonTeknisi.FlatStyle = FlatStyle.Flat;
            buttonTeknisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeknisi.ForeColor = SystemColors.Control;
            buttonTeknisi.IconChar = FontAwesome.Sharp.IconChar.Users;
            buttonTeknisi.IconColor = SystemColors.Control;
            buttonTeknisi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTeknisi.IconSize = 32;
            buttonTeknisi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTeknisi.Location = new Point(0, 3);
            buttonTeknisi.Name = "buttonTeknisi";
            buttonTeknisi.Size = new Size(131, 41);
            buttonTeknisi.TabIndex = 1;
            buttonTeknisi.Text = "Teknisi";
            buttonTeknisi.TextAlign = ContentAlignment.MiddleRight;
            buttonTeknisi.UseVisualStyleBackColor = false;
            buttonTeknisi.Click += buttonTeknisi_Click;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(31, 30, 68);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(165, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(940, 69);
            panel5.TabIndex = 2;
            // 
            // FormKomponen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1105, 620);
            Controls.Add(panel5);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKomponen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKomponen";
            Load += FormKomponen_Load;
            sidebar.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panelSidebar;
        private Label label1;
        private PictureBox buttonMenu;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton buttonKomponen;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton buttonJasa;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton buttonTeknisi;
        private System.Windows.Forms.Timer timerSidebar;
        private Panel panel5;
    }
}