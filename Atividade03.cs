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
    public partial class Atividade03 : Form
    {
        public Atividade03()
        {
            InitializeComponent();
        }

        private void btnTrocaCor_Click(object sender, EventArgs e)
        {
            if (rdbVermelho.Checked)
            {
                this.BackColor = Color.Red;
            }
            if (rdbAzul.Checked)
            {
                this.BackColor = Color.Blue;
            }
            if (rdbAmarelo.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }
    }
}
