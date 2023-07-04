namespace TrabalhoLogPForm
{
    partial class Atividade01
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
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.cmbFinal = new System.Windows.Forms.ComboBox();
            this.List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbInicio
            // 
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbInicio.Location = new System.Drawing.Point(41, 21);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(191, 21);
            this.cmbInicio.TabIndex = 0;
            this.cmbInicio.Text = "0";
            this.cmbInicio.SelectedIndexChanged += new System.EventHandler(this.cmbInicio_SelectedIndexChanged);
            // 
            // cmbFinal
            // 
            this.cmbFinal.FormattingEnabled = true;
            this.cmbFinal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbFinal.Location = new System.Drawing.Point(41, 48);
            this.cmbFinal.Name = "cmbFinal";
            this.cmbFinal.Size = new System.Drawing.Size(191, 21);
            this.cmbFinal.TabIndex = 1;
            this.cmbFinal.Text = "0";
            this.cmbFinal.SelectedIndexChanged += new System.EventHandler(this.cmbFinal_SelectedIndexChanged);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(12, 75);
            this.List.MultiColumn = true;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(220, 173);
            this.List.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // Atividade01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.cmbFinal);
            this.Controls.Add(this.cmbInicio);
            this.Name = "Atividade01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atividade01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInicio;
        private System.Windows.Forms.ComboBox cmbFinal;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}