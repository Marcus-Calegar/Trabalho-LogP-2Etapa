namespace TrabalhoLogPForm
{
    partial class Atividade03
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
            this.rdbAmarelo = new System.Windows.Forms.RadioButton();
            this.rdbAzul = new System.Windows.Forms.RadioButton();
            this.rdbVermelho = new System.Windows.Forms.RadioButton();
            this.btnTrocaCor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma opcao para trocar a cor de fundo:";
            // 
            // rdbAmarelo
            // 
            this.rdbAmarelo.AutoSize = true;
            this.rdbAmarelo.Location = new System.Drawing.Point(16, 43);
            this.rdbAmarelo.Name = "rdbAmarelo";
            this.rdbAmarelo.Size = new System.Drawing.Size(63, 17);
            this.rdbAmarelo.TabIndex = 1;
            this.rdbAmarelo.TabStop = true;
            this.rdbAmarelo.Text = "Amarelo";
            this.rdbAmarelo.UseVisualStyleBackColor = true;
            // 
            // rdbAzul
            // 
            this.rdbAzul.AutoSize = true;
            this.rdbAzul.Location = new System.Drawing.Point(16, 67);
            this.rdbAzul.Name = "rdbAzul";
            this.rdbAzul.Size = new System.Drawing.Size(45, 17);
            this.rdbAzul.TabIndex = 2;
            this.rdbAzul.TabStop = true;
            this.rdbAzul.Text = "Azul";
            this.rdbAzul.UseVisualStyleBackColor = true;
            // 
            // rdbVermelho
            // 
            this.rdbVermelho.AutoSize = true;
            this.rdbVermelho.Location = new System.Drawing.Point(16, 91);
            this.rdbVermelho.Name = "rdbVermelho";
            this.rdbVermelho.Size = new System.Drawing.Size(69, 17);
            this.rdbVermelho.TabIndex = 3;
            this.rdbVermelho.TabStop = true;
            this.rdbVermelho.Text = "Vermelho";
            this.rdbVermelho.UseVisualStyleBackColor = true;
            // 
            // btnTrocaCor
            // 
            this.btnTrocaCor.Location = new System.Drawing.Point(16, 119);
            this.btnTrocaCor.Name = "btnTrocaCor";
            this.btnTrocaCor.Size = new System.Drawing.Size(236, 32);
            this.btnTrocaCor.TabIndex = 4;
            this.btnTrocaCor.Text = "Trocar a cor de fundo";
            this.btnTrocaCor.UseVisualStyleBackColor = true;
            this.btnTrocaCor.Click += new System.EventHandler(this.btnTrocaCor_Click);
            // 
            // Atividade03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 174);
            this.Controls.Add(this.btnTrocaCor);
            this.Controls.Add(this.rdbVermelho);
            this.Controls.Add(this.rdbAzul);
            this.Controls.Add(this.rdbAmarelo);
            this.Controls.Add(this.label1);
            this.Name = "Atividade03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atividade03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbAmarelo;
        private System.Windows.Forms.RadioButton rdbAzul;
        private System.Windows.Forms.RadioButton rdbVermelho;
        private System.Windows.Forms.Button btnTrocaCor;
    }
}