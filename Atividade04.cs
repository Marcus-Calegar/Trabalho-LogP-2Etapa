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
    public partial class Atividade04 : Form
    {
        public Atividade04()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Total = 0;

            if (chbArroz.Checked)            
                Total += 26;
            if (chbFeijao.Checked)
                Total += 8.6;
            if (chbOleo.Checked)
                Total += 7.3;
            if (chbAcucar.Checked)
                Total += 19.2;
            if (chbMacarrao.Checked)
                Total += 6.7;
            if (chbMaionese.Checked)
                Total += 4.6;
            if (chbLeite.Checked)
                Total += 4.89;
            if (chbManteiga.Checked)
                Total += 18.2;
            if (chbOvos.Checked)
                Total += 7.3;
            if (chbSal.Checked)
                Total += 4.1;

            txtTotal.Text = Total.ToString("C");
        }
    }
}
