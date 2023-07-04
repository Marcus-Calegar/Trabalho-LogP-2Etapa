using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLogPForm
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ex01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade01 Ex1 = new Atividade01();
            Ex1.ShowDialog();
        }

        private void ex02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade02 Ex2 = new Atividade02();
            Ex2.ShowDialog();
        }

        private void ex03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade03 Ex3 = new Atividade03();
            Ex3.ShowDialog();
        }

        private void ex04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade04 Ex4 = new Atividade04();
            Ex4.ShowDialog();
        }
    }
}
