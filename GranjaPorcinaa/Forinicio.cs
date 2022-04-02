using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranjaPorcinaa
{
    public partial class Forinicio : Form
    {
        public Forinicio()
        {
            InitializeComponent();
        }

        private void butCerditos_Click(object sender, EventArgs e)
        {
            ForCerditos forCerditos = new ForCerditos();
            forCerditos.Show();
        }

        private void butVacunas_Click(object sender, EventArgs e)
        {
            ForVacunas forVacunas = new ForVacunas();
            forVacunas.Show();
        }

        private void butVentas_Click(object sender, EventArgs e)
        {
            ForVentas forVentas = new ForVentas();
            forVentas.Show();
        }
    }
}
