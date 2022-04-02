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
    public partial class ForCerditos : Form
    {
         int id = 0;
        public ForCerditos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCerditos.Rows[e.RowIndex].Cells[0].Value);
            texNombre.Text = dgvCerditos.CurrentRow.Cells[1].Value.ToString();
            texNumcorral.Text = dgvCerditos.CurrentRow.Cells[2].Value.ToString();
            texpeso.Text = dgvCerditos.CurrentRow.Cells[3].Value.ToString();
            dateIngreso.Value = Convert.ToDateTime(dgvCerditos.CurrentRow.Cells[4].Value.ToString());
            dateNacimiento.Value = Convert.ToDateTime(dgvCerditos.CurrentRow.Cells[5].Value.ToString());

        }

        private void ForCerditos_Load(object sender, EventArgs e)
        {
            ListaCerditos();
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            using (var Context = new AplicationDBContext())
            {
                var cerdito = new Cerditos();
                cerdito.Nombre = texNombre.Text;
                cerdito.NumCorral = Convert.ToInt32(texNumcorral.Text);
                cerdito.Peso = Convert.ToInt32(texpeso.Text);
                cerdito.DateIngreso = dateIngreso.Value.Date;
                cerdito.DateNacimiento = dateNacimiento.Value.Date;
                Context.Cerditos.Add(cerdito);
                Context.SaveChanges();

                var Cerditos = Context.Cerditos.ToList();
                dgvCerditos.DataSource = Cerditos;

            }
        }
        private void ListaCerditos()
        {
            using (var Context = new AplicationDBContext())
            {
                var cerditos = Context.Cerditos.ToList();
                dgvCerditos.DataSource = cerditos;
            }
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            using (var contex = new AplicationDBContext())
            {
                if (id != 0)
                {
                    var cerdito = contex.Cerditos.First(x => x.Id == id);
                    if (cerdito != null)
                    {
                        cerdito.Nombre = texNombre.Text;
                        cerdito.NumCorral = Convert.ToInt32(texNumcorral.Text);
                        cerdito.Peso = Convert.ToInt32(texpeso.Text);
                        cerdito.DateIngreso = dateIngreso.Value.Date;
                        cerdito.DateNacimiento = dateNacimiento.Value.Date;
                        contex.SaveChanges();
                        ListaCerditos();
                    }
                }

            }
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            id = 0;
            texNombre.Text = "";
            texNumcorral.Text = "";
            texpeso.Text = "";
            dateIngreso.Value = Convert.ToDateTime(DateTime.Now);
            dateNacimiento.Value = Convert.ToDateTime(DateTime.Now);

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            using (var contex = new AplicationDBContext())
            {
                var cerdito = contex.Cerditos.First(x => x.Id == id);
                if (cerdito != null)
                {
                    contex.Cerditos.Remove(cerdito);
                    contex.SaveChanges();
                    ListaCerditos();
                }
            }
        }
    }
}