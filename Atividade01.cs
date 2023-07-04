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
    public partial class Atividade01 : Form
    {

        public int Inicio;
        public int Final;
        public Atividade01()
        {
            InitializeComponent();
        }

        public void ValoresFor(int inicio, int fim)
        {
            Inicio = inicio;
            Final = fim;

            if (Inicio != 0)
            {

                if (Final < Inicio)
                {
                    for (int x = Inicio; x >= Final; x--)
                    {
                        List.Items.Add(x.ToString());
                    }
                }
                else
                {
                    for (int x = Inicio; x <= Final; x++)
                    {
                        List.Items.Add(x.ToString());
                    }
                }
            }
        }

        private void cmbFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            List.Items.Clear();
            ValoresFor(int.Parse(cmbInicio.Text), int.Parse(cmbFinal.Text));
        }

        private void cmbInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            List.Items.Clear();
            ValoresFor(int.Parse(cmbInicio.Text), int.Parse(cmbFinal.Text));
        }
    }
}
