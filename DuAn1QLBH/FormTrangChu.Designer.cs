﻿namespace PRL
{
    partial class FormTrangChu
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            mstr_Menu = new MenuStrip();
            tool_BanHang = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            nhàToolStripMenuItem = new ToolStripMenuItem();
            loạiHàngToolStripMenuItem = new ToolStripMenuItem();
            giảmGiáToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mstr_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capture;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox2.Image = Properties.Resources.logo_shop_quan_ao;
            pictureBox2.Location = new Point(209, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1277, 781);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // mstr_Menu
            // 
            mstr_Menu.BackColor = Color.FromArgb(255, 224, 192);
            mstr_Menu.Dock = DockStyle.Left;
            mstr_Menu.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mstr_Menu.GripStyle = ToolStripGripStyle.Visible;
            mstr_Menu.Items.AddRange(new ToolStripItem[] { tool_BanHang, hóaĐơnToolStripMenuItem, nhàToolStripMenuItem, loạiHàngToolStripMenuItem, giảmGiáToolStripMenuItem, kháchHàngToolStripMenuItem, thoátToolStripMenuItem });
            mstr_Menu.Location = new Point(0, 0);
            mstr_Menu.Name = "mstr_Menu";
            mstr_Menu.Padding = new Padding(6, 180, 0, 2);
            mstr_Menu.Size = new Size(213, 831);
            mstr_Menu.TabIndex = 2;
            mstr_Menu.Text = "menuStrip1";
            mstr_Menu.ItemClicked += mstr_Menu_ItemClicked;
            // 
            // tool_BanHang
            // 
            tool_BanHang.Name = "tool_BanHang";
            tool_BanHang.Padding = new Padding(0, 30, 0, 10);
            tool_BanHang.Size = new Size(200, 77);
            tool_BanHang.Text = "Bán Hàng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Padding = new Padding(0, 30, 0, 10);
            hóaĐơnToolStripMenuItem.Size = new Size(200, 77);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // nhàToolStripMenuItem
            // 
            nhàToolStripMenuItem.Name = "nhàToolStripMenuItem";
            nhàToolStripMenuItem.Padding = new Padding(0, 30, 0, 10);
            nhàToolStripMenuItem.Size = new Size(200, 77);
            nhàToolStripMenuItem.Text = "Nhà Cung Cấp ";
            // 
            // loạiHàngToolStripMenuItem
            // 
            loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            loạiHàngToolStripMenuItem.Padding = new Padding(0, 30, 0, 10);
            loạiHàngToolStripMenuItem.Size = new Size(200, 77);
            loạiHàngToolStripMenuItem.Text = "Loại Hàng";
            // 
            // giảmGiáToolStripMenuItem
            // 
            giảmGiáToolStripMenuItem.Name = "giảmGiáToolStripMenuItem";
            giảmGiáToolStripMenuItem.Padding = new Padding(0, 30, 0, 10);
            giảmGiáToolStripMenuItem.Size = new Size(200, 77);
            giảmGiáToolStripMenuItem.Text = "Giảm Giá";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Padding = new Padding(0, 30, 0, 10);
            kháchHàngToolStripMenuItem.Size = new Size(200, 77);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Padding = new Padding(0, 30, 0, 10);
            thoátToolStripMenuItem.Size = new Size(200, 77);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(596, 6);
            label1.Name = "label1";
            label1.Size = new Size(356, 41);
            label1.TabIndex = 3;
            label1.Text = "QUẢN LÝ CỬA HÀNG";
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1484, 831);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(mstr_Menu);
            MainMenuStrip = mstr_Menu;
            MaximumSize = new Size(1500, 870);
            MinimumSize = new Size(750, 435);
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTrangChu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mstr_Menu.ResumeLayout(false);
            mstr_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip mstr_Menu;
        private ToolStripMenuItem tool_BanHang;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem nhàToolStripMenuItem;
        private ToolStripMenuItem loạiHàngToolStripMenuItem;
        private ToolStripMenuItem giảmGiáToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}