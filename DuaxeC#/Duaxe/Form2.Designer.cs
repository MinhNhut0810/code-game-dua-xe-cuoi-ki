namespace Duaxe
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.bien1 = new System.Windows.Forms.TextBox();
            this.bien2 = new System.Windows.Forms.TextBox();
            this.bien3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rock1 = new System.Windows.Forms.PictureBox();
            this.Mycar = new System.Windows.Forms.PictureBox();
            this.letrai = new System.Windows.Forms.PictureBox();
            this.lephai = new System.Windows.Forms.PictureBox();
            this.rock2 = new System.Windows.Forms.PictureBox();
            this.rock3 = new System.Windows.Forms.PictureBox();
            this.lephai2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letrai2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lephai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lephai2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letrai2)).BeginInit();
            this.SuspendLayout();
            // 
            // bien1
            // 
            this.bien1.Location = new System.Drawing.Point(169, -53);
            this.bien1.Multiline = true;
            this.bien1.Name = "bien1";
            this.bien1.Size = new System.Drawing.Size(10, 134);
            this.bien1.TabIndex = 0;
            // 
            // bien2
            // 
            this.bien2.Location = new System.Drawing.Point(168, 108);
            this.bien2.Multiline = true;
            this.bien2.Name = "bien2";
            this.bien2.Size = new System.Drawing.Size(11, 146);
            this.bien2.TabIndex = 1;
            // 
            // bien3
            // 
            this.bien3.Location = new System.Drawing.Point(169, 281);
            this.bien3.Multiline = true;
            this.bien3.Name = "bien3";
            this.bien3.Size = new System.Drawing.Size(10, 86);
            this.bien3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rock1
            // 
            this.rock1.Image = global::Duaxe.Properties.Resources.chướng_ngại_vật;
            this.rock1.Location = new System.Drawing.Point(109, 142);
            this.rock1.Name = "rock1";
            this.rock1.Size = new System.Drawing.Size(40, 42);
            this.rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock1.TabIndex = 8;
            this.rock1.TabStop = false;
            // 
            // Mycar
            // 
            this.Mycar.Image = global::Duaxe.Properties.Resources.ảnh_xe_đua;
            this.Mycar.Location = new System.Drawing.Point(89, 287);
            this.Mycar.Name = "Mycar";
            this.Mycar.Size = new System.Drawing.Size(37, 65);
            this.Mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mycar.TabIndex = 5;
            this.Mycar.TabStop = false;
            this.Mycar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // letrai
            // 
            this.letrai.Image = global::Duaxe.Properties.Resources.ảnh_lề_trái;
            this.letrai.Location = new System.Drawing.Point(0, 108);
            this.letrai.Name = "letrai";
            this.letrai.Size = new System.Drawing.Size(55, 365);
            this.letrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.letrai.TabIndex = 4;
            this.letrai.TabStop = false;
            // 
            // lephai
            // 
            this.lephai.Image = global::Duaxe.Properties.Resources.ảnh_lề_phải1;
            this.lephai.Location = new System.Drawing.Point(294, 0);
            this.lephai.Name = "lephai";
            this.lephai.Size = new System.Drawing.Size(56, 365);
            this.lephai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lephai.TabIndex = 3;
            this.lephai.TabStop = false;
            this.lephai.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rock2
            // 
            this.rock2.Image = global::Duaxe.Properties.Resources.chướng_ngại_vật;
            this.rock2.Location = new System.Drawing.Point(247, 50);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(41, 40);
            this.rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock2.TabIndex = 9;
            this.rock2.TabStop = false;
            // 
            // rock3
            // 
            this.rock3.Image = global::Duaxe.Properties.Resources.chướng_ngại_vật;
            this.rock3.Location = new System.Drawing.Point(73, 12);
            this.rock3.Name = "rock3";
            this.rock3.Size = new System.Drawing.Size(38, 41);
            this.rock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock3.TabIndex = 10;
            this.rock3.TabStop = false;
            // 
            // lephai2
            // 
            this.lephai2.Image = global::Duaxe.Properties.Resources.ảnh_lề_phải1;
            this.lephai2.Location = new System.Drawing.Point(294, -340);
            this.lephai2.Name = "lephai2";
            this.lephai2.Size = new System.Drawing.Size(56, 365);
            this.lephai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lephai2.TabIndex = 11;
            this.lephai2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Score: 0";
            // 
            // over
            // 
            this.over.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.over.BackColor = System.Drawing.Color.Yellow;
            this.over.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(89, 93);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(182, 34);
            this.over.TabIndex = 13;
            this.over.Text = "GAME OVER";
            this.over.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click_1);
            // 
            // letrai2
            // 
            this.letrai2.Image = global::Duaxe.Properties.Resources.ảnh_lề_trái;
            this.letrai2.Location = new System.Drawing.Point(0, -250);
            this.letrai2.Name = "letrai2";
            this.letrai2.Size = new System.Drawing.Size(55, 365);
            this.letrai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.letrai2.TabIndex = 15;
            this.letrai2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(346, 364);
            this.Controls.Add(this.over);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lephai2);
            this.Controls.Add(this.rock3);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.Mycar);
            this.Controls.Add(this.letrai);
            this.Controls.Add(this.lephai);
            this.Controls.Add(this.bien3);
            this.Controls.Add(this.bien2);
            this.Controls.Add(this.bien1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.letrai2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lephai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lephai2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letrai2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bien1;
        private System.Windows.Forms.TextBox bien2;
        private System.Windows.Forms.TextBox bien3;
        private System.Windows.Forms.PictureBox lephai;
        private System.Windows.Forms.PictureBox letrai;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Mycar;
        private System.Windows.Forms.PictureBox rock1;
        private System.Windows.Forms.PictureBox rock2;
        private System.Windows.Forms.PictureBox rock3;
        private System.Windows.Forms.PictureBox lephai2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox letrai2;
    }
}