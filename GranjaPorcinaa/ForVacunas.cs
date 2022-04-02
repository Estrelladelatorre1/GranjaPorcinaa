using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GranjaPorcinaa.Data;
using GranjaPorcinaa.Models;

namespace GranjaPorcinaa
{
    
    public partial class ForVacunas : Form
    {
        private int id = 0;
        public ForVacunas()
        {
            InitializeComponent();
        }
        private void ListaVacunas()
        {
            using (var Context = new AplicationDBContext())
            {
                var vacuana = Context.Vacunas.ToList();
                dgvvacuna.DataSource = vacuana;
            }
        }

        private void ForVacunas_Load(object sender, EventArgs e)
        {
            ListaVacunas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvvacuna.Rows[e.RowIndex].Cells[0].Value);
            texIdcer.Text = dgvvacuna.CurrentRow.Cells[1].Value.ToString();
            texNomVacuna.Text = dgvvacuna.CurrentRow.Cells[2].Value.ToString();
            dateVacuna.Value = Convert.ToDateTime(dgvvacuna.CurrentRow.Cells[3].Value.ToString());   
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            using (var Context = new AplicationDBContext())
            { 
            var vacuna = new Vacunas();
             //vacuna.Id= Convert.ToInt32(texid.Text);
             vacuna.IdCer = Convert.ToInt32(texIdcer.Text);
            vacuna.NomVacu = texNomVacuna.Text;
            vacuna.DateVacuna=dateVacuna.Value.Date;

                Context.Vacunas.Add(vacuna);
                Context.SaveChanges();
                var Vacuna = Context.Vacunas.ToList();
                dgvvacuna.DataSource = Vacuna;

        }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            using (var contex = new AplicationDBContext())
            {
                var vacuna = contex.Vacunas.First(x => x.Id == id);
                if (vacuna != null)
                {
                    contex.Vacunas.Remove(vacuna);
                    contex.SaveChanges();
                    ListaVacunas();
                }
            }
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            id = 0;
            texIdcer.Text = "";
            texNomVacuna.Text = "";
            dateVacuna.Value = Convert.ToDateTime(DateTime.Now);
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            using (var contex = new AplicationDBContext())
            {
                if (id != 0)
                {
                    var vacuna = contex.Vacunas.First(x => x.Id == id);
                    if (vacuna != null)
                    {
                        vacuna.IdCer = Convert.ToInt32(texIdcer.Text);
                        vacuna.NomVacu = texNomVacuna.Text;
                        vacuna.DateVacuna = dateVacuna.Value.Date;
                        contex.SaveChanges();
                        ListaVacunas();
                    }
                }

            }
        }
    }

}
