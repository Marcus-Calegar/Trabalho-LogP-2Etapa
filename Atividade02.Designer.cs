namespace TrabalhoLogPForm
{
    partial class Atividade02
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
            this.label1 = new System.Windows.Forms.Label();
            this.Texto = new System.Windows.Forms.TextBox();
            this.lblCaixaAlta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite algo que o texto seja exibido em Maiusculo:";
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(15, 26);
            this.Texto.Multiline = true;
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(239, 66);
            this.Texto.TabIndex = 1;
            this.Texto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCaixaAlta
            // 
            this.lblCaixaAlta.AutoSize = true;
            this.lblCaixaAlta.Location = new System.Drawing.Point(12, 115);
            this.lblCaixaAlta.Name = "lblCaixaAlta";
            this.lblCaixaAlta.Size = new System.Drawing.Size(0, 13);
            this.lblCaixaAlta.TabIndex = 2;
            this.lblCaixaAlta.Click += new System.EventHandler(this.label2_Click);
            // 
            // Atividade02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 220);
            this.Controls.Add(this.lblCaixaAlta);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.label1);
            this.Name = "Atividade02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atividade02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.Label lblCaixaAlta;
    }
}