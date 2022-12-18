
namespace EDNEVNIK
{
    partial class Glavni_meni
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jedanSlogBezFkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedanSlogSaFkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBezFkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaSaFkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_user = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedanSlogBezFkToolStripMenuItem,
            this.jedanSlogSaFkToolStripMenuItem,
            this.tabelaBezFkToolStripMenuItem,
            this.tabelaSaFkToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jedanSlogBezFkToolStripMenuItem
            // 
            this.jedanSlogBezFkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem});
            this.jedanSlogBezFkToolStripMenuItem.Name = "jedanSlogBezFkToolStripMenuItem";
            this.jedanSlogBezFkToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.jedanSlogBezFkToolStripMenuItem.Text = "Jedan slog bez fk";
            // 
            // jedanSlogSaFkToolStripMenuItem
            // 
            this.jedanSlogSaFkToolStripMenuItem.Name = "jedanSlogSaFkToolStripMenuItem";
            this.jedanSlogSaFkToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.jedanSlogSaFkToolStripMenuItem.Text = "Jedan slog sa fk";
            // 
            // tabelaBezFkToolStripMenuItem
            // 
            this.tabelaBezFkToolStripMenuItem.Name = "tabelaBezFkToolStripMenuItem";
            this.tabelaBezFkToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.tabelaBezFkToolStripMenuItem.Text = "Tabela bez fk";
            // 
            // tabelaSaFkToolStripMenuItem
            // 
            this.tabelaSaFkToolStripMenuItem.Name = "tabelaSaFkToolStripMenuItem";
            this.tabelaSaFkToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tabelaSaFkToolStripMenuItem.Text = "Tabela sa fk";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobaToolStripMenuItem.Text = "Osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Location = new System.Drawing.Point(594, 10);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(35, 13);
            this.l_user.TabIndex = 1;
            this.l_user.Text = "label1";
            // 
            // Glavni_meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_user);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavni_meni";
            this.Text = "Glavni_meni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavni_meni_FormClosed);
            this.Load += new System.EventHandler(this.Glavni_meni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jedanSlogBezFkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedanSlogSaFkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBezFkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaSaFkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.Label l_user;
    }
}