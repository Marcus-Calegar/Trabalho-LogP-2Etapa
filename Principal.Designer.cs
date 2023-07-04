namespace TrabalhoLogPForm
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex01ToolStripMenuItem,
            this.ex02ToolStripMenuItem,
            this.ex03ToolStripMenuItem,
            this.ex04ToolStripMenuItem});
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // ex01ToolStripMenuItem
            // 
            this.ex01ToolStripMenuItem.Name = "ex01ToolStripMenuItem";
            this.ex01ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ex01ToolStripMenuItem.Text = "Atividade 01";
            this.ex01ToolStripMenuItem.Click += new System.EventHandler(this.ex01ToolStripMenuItem_Click);
            // 
            // ex02ToolStripMenuItem
            // 
            this.ex02ToolStripMenuItem.Name = "ex02ToolStripMenuItem";
            this.ex02ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ex02ToolStripMenuItem.Text = "Atividade 02";
            this.ex02ToolStripMenuItem.Click += new System.EventHandler(this.ex02ToolStripMenuItem_Click);
            // 
            // ex03ToolStripMenuItem
            // 
            this.ex03ToolStripMenuItem.Name = "ex03ToolStripMenuItem";
            this.ex03ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ex03ToolStripMenuItem.Text = "Atividade 03";
            this.ex03ToolStripMenuItem.Click += new System.EventHandler(this.ex03ToolStripMenuItem_Click);
            // 
            // ex04ToolStripMenuItem
            // 
            this.ex04ToolStripMenuItem.Name = "ex04ToolStripMenuItem";
            this.ex04ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ex04ToolStripMenuItem.Text = "Atividade 04";
            this.ex04ToolStripMenuItem.Click += new System.EventHandler(this.ex04ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 174);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex03ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex04ToolStripMenuItem;
    }
}

